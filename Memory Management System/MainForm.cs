using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Management_System
{
    public partial class MainForm : Form
    {
        int methodFlag = 1;
        int time = 0;

        public int[,,] PageTable = new int[101, 17, 2];//PageNum,PsyNum

        public int[,] memory = new int[1024, 3];//ID,PageNum,AcTime
        Stack me = new Stack();
        Stack te1 = new Stack();
        Queue te2 = new Queue();
        struct st
        {
           public int min;
            public int max;
            public int id;
        }
        public MainForm()
        {
            InitializeComponent();
            for (int i = 0; i < 1024; i++)
            {
                memory[i, 0] = -1;
            }
                
            for (int i = 0; i < 101; i++)
                PageTable[i, 0, 0] = -1;
        }

        void PrintList()
        {
            MemoryList.Clear();
            this.MemoryList.Columns.Add("物理地址", 60, HorizontalAlignment.Left);
            this.MemoryList.Columns.Add("进程ID", 60, HorizontalAlignment.Left);
            if (methodFlag == 1)
            {
                this.MemoryList.Columns.Add("页号", 60, HorizontalAlignment.Left);
                this.MemoryList.Columns.Add("上次访问时间", 180, HorizontalAlignment.Left);
            }

            this.MemoryList.BeginUpdate();
            for (int i = 0; i < 1024; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = "" + i;
                if (memory[i, 0] == -1)
                    lvi.SubItems.Add("空");
                else
                    lvi.SubItems.Add(memory[i, 0] + "");

                if (methodFlag == 1)
                {
                    if(memory[i, 0] == -1)
                    {
                        lvi.SubItems.Add("");
                        lvi.SubItems.Add("");
                    }
                    else
                    {
                        lvi.SubItems.Add(memory[i, 1] + "");
                        lvi.SubItems.Add(memory[i, 2] + "");
                    }
                    
                }

                this.MemoryList.Items.Add(lvi);
            }
            this.MemoryList.View = View.Details;
            this.MemoryList.EndUpdate();

        }

        private void ChangrButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1024; i++)
                memory[i, 0] = -1;
            for (int i = 0; i < 101; i++)
                PageTable[i, 0, 0] = -1;
            if (methodFlag == 0)
            {
                methodFlag = 1;
                MethodLabel.Text = "当前内存管理方法：页式存储管理";
                AccessProcess.Visible = true;
                OutputText.Clear();
                OutputText.Visible = true;
                PageTableLabel.Text = "页表";
            }
            else if (methodFlag == 1)
            {
                if(me.Count!=0)
                me.Clear();
                st block;
                block.min = 0;
                block.max = 1023;
                block.id = -1;
                me.Push(block);
                methodFlag = 0;
                MethodLabel.Text = "当前内存管理方法：动态分区";
                AccessProcess.Visible = false;
                OutputText.Clear();
                OutputText.Visible = false;
                PageTableLabel.Text = " ";
            }
            PrintList();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            time++;
            if (PageTable[(int)PID.Value, 0, 0] != -1)
            {
                MessageBox.Show("已经存在ID为" + (int)PID.Value + "的进程", "警告");
                return;
            }
            else
            {
                PageTable[(int)PID.Value, 0, 0] = 1;
                PageTable[(int)PID.Value, 0, 1] = (int)PReq.Value;
            }

            if (methodFlag == 0)
            {
                while (me.Count != 0)
                {
                    st temp = (st)me.Pop();
                    if (temp.id != -1)
                    {
                        te1.Push(temp);
                        continue;
                    }

                    int n = temp.max - temp.min + 1;
                    if (n < (int)PReq.Value)
                    {
                        te1.Push(temp);
                        continue;
                    }
                        
                    else if(n/2< (int)PReq.Value)
                    {
                        temp.id = (int)PID.Value;
                        for(int j = temp.min; j <= temp.max; j++)
                        {
                            memory[j, 0] = (int)PID.Value;
                        }
                        break;
                    }
                    else
                    {
                        while (n / 2 >= (int)PReq.Value)
                        {
                            st temp1;
                            temp1.min = temp.max- n/ 2+1 ;
                            temp1.max = temp.max;
                            temp1.id = -1;
                            te2.Enqueue(temp1);
                            temp.max = temp1.min - 1;
                            n = temp.max - temp.min + 1;
                        }
                        
                        temp.id = (int)PID.Value;
                        for (int j = temp.min; j <= temp.max; j++)
                        {
                            
                            memory[j, 0] = (int)PID.Value;
                        }
                    }
                    while (te2.Count != 0)
                    {
                        st temp2 = (st)te2.Dequeue();
                        me.Push(temp2);
                    }
                    me.Push(temp);
                    break;
                }
                
                while (te1.Count != 0)
                {
                    st temp = (st)te1.Pop();
                    me.Push(temp);
                }
                
            }
            if (methodFlag == 1)
            {
                int i = 0, count = 0;
                while (count < 16 && i < 1024&&count< (int)PReq.Value)
                {
                    if (memory[i, 0] == -1)
                    {
                        memory[i, 0] = (int)PID.Value;
                        memory[i, 1] = count;
                        memory[i, 2] = time;
                        PageTable[(int)PID.Value, count + 1, 0] = count;
                        PageTable[(int)PID.Value, count + 1, 1] = i;
                        count++;
                    }
                    else
                        i++;
                }
            }

            PrintList();
            if(methodFlag == 1)
            {
                PrintPageList((int)PID.Value);
            }
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            OutputText.Text = "";
            if (PageTable[(int)EndID.Value, 0, 0] == -1)
            {
                MessageBox.Show("找不到该进程");
                return;
            }
            else
                PageTable[(int)EndID.Value, 0, 0] = -1;
            for (int i = 0; i < 1024; i++)
                if (memory[i, 0] == (int)EndID.Value)
                    memory[i, 0] = -1;
            if (methodFlag == 0)
            {
                while (me.Count != 0)
                {
                    st temp = (st)me.Pop();
                    if(temp.id == (int)EndID.Value)
                    {
                        temp.id = -1;
                        me.Push(temp);
                        break;
                    }
                    te1.Push(temp);
                }
                while (te1.Count != 0)
                {
                    st temp = (st)te1.Pop();
                    me.Push(temp);
                }
            }
            PrintList();
        }

        void PrintPageList(int i)
        {
            OutputText.Text = "";
            OutputText.Text = "ID为" + i + "的进程的页表如下\r\n";
            int n = PageTable[i, 0, 1];
            int k = 1;
            if (n > 16)
                n = 16;
            while (k <= n)
            {
                OutputText.AppendText("逻辑页号："+ PageTable[i, k, 0] + "\t实际内存地址:"+ PageTable[i, k, 1] + "\r\n");
                k++;
            }
            if (PageTable[i, 0, 1] > 16)
                OutputText.AppendText("一共有"+ PageTable[i, 0, 1] + "个逻辑页，剩余逻辑页没有被放入内存.");
        }

        private void Access_Click(object sender, EventArgs e)
        {
            time++;
            bool find = false;
            if (PageTable[(int)Aid.Value, 0, 0] == -1)
            {
                MessageBox.Show("找不到该进程");
                return;
            }
            for(int i = 1; i <= 16; i++)
            {
                if((int) Ala.Value == PageTable[(int)Aid.Value, i, 0])
                {
                    find = true;
                    memory[PageTable[(int)Aid.Value, i, 1], 2] = time;
                    MessageBox.Show("该页在物理内存中，成功访问。\n在内存中地址为"+ PageTable[(int)Aid.Value, i, 1]);
                    break;
                }

            }
            if (!find)
            {
                MessageBox.Show("该页不在在物理内存中，访问失败。");
                int goal = 1;
                int atime = memory[PageTable[(int)Aid.Value, 1, 1], 2];
                for(int i = 16; i >= 16; i--)
                {
                    if(memory[PageTable[(int)Aid.Value, i, 1], 2] < atime)
                    {
                        atime=memory[PageTable[(int)Aid.Value, i, 1], 2];
                        goal = i;
                    }
                }


                MessageBox.Show("现在将实际内存地址在"+ PageTable[(int)Aid.Value, goal, 1] + "\n逻辑页"+ memory[PageTable[(int)Aid.Value, goal, 1],1]+"换出内存");
                
                memory[PageTable[(int)Aid.Value, goal, 1], 1] = (int)Ala.Value;
                memory[PageTable[(int)Aid.Value, goal, 1], 2] = time;
                PageTable[(int)Aid.Value, goal, 0] = (int)(int)Ala.Value;

            }
            PrintList();
            PrintPageList((int)Aid.Value);

            
        }
    }
}

