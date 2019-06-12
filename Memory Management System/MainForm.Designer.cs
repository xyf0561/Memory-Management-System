namespace Memory_Management_System
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.MemoryList = new System.Windows.Forms.ListView();
            this.ChangrButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MethodLabel = new System.Windows.Forms.Label();
            this.CreateProcess = new System.Windows.Forms.GroupBox();
            this.PID = new System.Windows.Forms.NumericUpDown();
            this.PReq = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.EndProcess = new System.Windows.Forms.GroupBox();
            this.EndID = new System.Windows.Forms.NumericUpDown();
            this.EndButton = new System.Windows.Forms.Button();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.PageTableLabel = new System.Windows.Forms.Label();
            this.AccessProcess = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Ala = new System.Windows.Forms.NumericUpDown();
            this.Aid = new System.Windows.Forms.NumericUpDown();
            this.AccessButton = new System.Windows.Forms.Button();
            this.CreateProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PReq)).BeginInit();
            this.EndProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndID)).BeginInit();
            this.AccessProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前内存状况（共1024K）";
            // 
            // MemoryList
            // 
            this.MemoryList.Location = new System.Drawing.Point(26, 59);
            this.MemoryList.Name = "MemoryList";
            this.MemoryList.Size = new System.Drawing.Size(678, 706);
            this.MemoryList.TabIndex = 1;
            this.MemoryList.UseCompatibleStateImageBehavior = false;
            // 
            // ChangrButton
            // 
            this.ChangrButton.Location = new System.Drawing.Point(1221, 14);
            this.ChangrButton.Name = "ChangrButton";
            this.ChangrButton.Size = new System.Drawing.Size(138, 54);
            this.ChangrButton.TabIndex = 2;
            this.ChangrButton.Text = "切换方法";
            this.ChangrButton.UseVisualStyleBackColor = true;
            this.ChangrButton.Click += new System.EventHandler(this.ChangrButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(1392, 14);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(138, 54);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "退出";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MethodLabel
            // 
            this.MethodLabel.AutoSize = true;
            this.MethodLabel.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MethodLabel.Location = new System.Drawing.Point(733, 24);
            this.MethodLabel.Name = "MethodLabel";
            this.MethodLabel.Size = new System.Drawing.Size(463, 30);
            this.MethodLabel.TabIndex = 4;
            this.MethodLabel.Text = "当前内存管理方法：页式存储管理";
            // 
            // CreateProcess
            // 
            this.CreateProcess.Controls.Add(this.PID);
            this.CreateProcess.Controls.Add(this.PReq);
            this.CreateProcess.Controls.Add(this.label2);
            this.CreateProcess.Controls.Add(this.label3);
            this.CreateProcess.Controls.Add(this.ConfirmButton);
            this.CreateProcess.Location = new System.Drawing.Point(776, 111);
            this.CreateProcess.Name = "CreateProcess";
            this.CreateProcess.Size = new System.Drawing.Size(393, 314);
            this.CreateProcess.TabIndex = 5;
            this.CreateProcess.TabStop = false;
            this.CreateProcess.Text = "创建进程";
            // 
            // PID
            // 
            this.PID.Location = new System.Drawing.Point(232, 77);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(100, 28);
            this.PID.TabIndex = 24;
            // 
            // PReq
            // 
            this.PReq.Location = new System.Drawing.Point(232, 128);
            this.PReq.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.PReq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PReq.Name = "PReq";
            this.PReq.Size = new System.Drawing.Size(100, 28);
            this.PReq.TabIndex = 23;
            this.PReq.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "内存需求（单位K）";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "进程ID";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(91, 208);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(194, 61);
            this.ConfirmButton.TabIndex = 20;
            this.ConfirmButton.Text = "创建完毕";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // EndProcess
            // 
            this.EndProcess.Controls.Add(this.EndID);
            this.EndProcess.Controls.Add(this.EndButton);
            this.EndProcess.Location = new System.Drawing.Point(1198, 111);
            this.EndProcess.Name = "EndProcess";
            this.EndProcess.Size = new System.Drawing.Size(393, 117);
            this.EndProcess.TabIndex = 25;
            this.EndProcess.TabStop = false;
            this.EndProcess.Text = "结束进程";
            // 
            // EndID
            // 
            this.EndID.Location = new System.Drawing.Point(35, 46);
            this.EndID.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.EndID.Name = "EndID";
            this.EndID.Size = new System.Drawing.Size(100, 28);
            this.EndID.TabIndex = 25;
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(174, 27);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(194, 61);
            this.EndButton.TabIndex = 20;
            this.EndButton.Text = "结束进程";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // OutputText
            // 
            this.OutputText.AcceptsTab = true;
            this.OutputText.Location = new System.Drawing.Point(1198, 328);
            this.OutputText.MaxLength = 3276700;
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.ReadOnly = true;
            this.OutputText.Size = new System.Drawing.Size(427, 437);
            this.OutputText.TabIndex = 26;
            // 
            // PageTableLabel
            // 
            this.PageTableLabel.AutoSize = true;
            this.PageTableLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PageTableLabel.Location = new System.Drawing.Point(1194, 284);
            this.PageTableLabel.Name = "PageTableLabel";
            this.PageTableLabel.Size = new System.Drawing.Size(82, 24);
            this.PageTableLabel.TabIndex = 27;
            this.PageTableLabel.Text = "页表：";
            // 
            // AccessProcess
            // 
            this.AccessProcess.Controls.Add(this.label5);
            this.AccessProcess.Controls.Add(this.label4);
            this.AccessProcess.Controls.Add(this.Ala);
            this.AccessProcess.Controls.Add(this.Aid);
            this.AccessProcess.Controls.Add(this.AccessButton);
            this.AccessProcess.Location = new System.Drawing.Point(776, 444);
            this.AccessProcess.Name = "AccessProcess";
            this.AccessProcess.Size = new System.Drawing.Size(393, 321);
            this.AccessProcess.TabIndex = 26;
            this.AccessProcess.TabStop = false;
            this.AccessProcess.Text = "访问进程";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "逻辑地址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "进程ID";
            // 
            // Ala
            // 
            this.Ala.Location = new System.Drawing.Point(219, 113);
            this.Ala.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.Ala.Name = "Ala";
            this.Ala.Size = new System.Drawing.Size(100, 28);
            this.Ala.TabIndex = 26;
            // 
            // Aid
            // 
            this.Aid.Location = new System.Drawing.Point(219, 56);
            this.Aid.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.Aid.Name = "Aid";
            this.Aid.Size = new System.Drawing.Size(100, 28);
            this.Aid.TabIndex = 25;
            // 
            // AccessButton
            // 
            this.AccessButton.Location = new System.Drawing.Point(104, 217);
            this.AccessButton.Name = "AccessButton";
            this.AccessButton.Size = new System.Drawing.Size(194, 61);
            this.AccessButton.TabIndex = 20;
            this.AccessButton.Text = "访问";
            this.AccessButton.UseVisualStyleBackColor = true;
            this.AccessButton.Click += new System.EventHandler(this.Access_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1669, 821);
            this.Controls.Add(this.AccessProcess);
            this.Controls.Add(this.PageTableLabel);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.EndProcess);
            this.Controls.Add(this.CreateProcess);
            this.Controls.Add(this.MethodLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ChangrButton);
            this.Controls.Add(this.MemoryList);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "内存管理";
            this.CreateProcess.ResumeLayout(false);
            this.CreateProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PReq)).EndInit();
            this.EndProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EndID)).EndInit();
            this.AccessProcess.ResumeLayout(false);
            this.AccessProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Aid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView MemoryList;
        private System.Windows.Forms.Button ChangrButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label MethodLabel;
        private System.Windows.Forms.GroupBox CreateProcess;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.NumericUpDown PReq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox EndProcess;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Label PageTableLabel;
        private System.Windows.Forms.NumericUpDown PID;
        private System.Windows.Forms.NumericUpDown EndID;
        private System.Windows.Forms.GroupBox AccessProcess;
        private System.Windows.Forms.NumericUpDown Aid;
        private System.Windows.Forms.Button AccessButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Ala;
    }
}

