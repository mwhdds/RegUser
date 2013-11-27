namespace RegUser
{
    partial class FrmUserInfo
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSingleInfo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxBB = new System.Windows.Forms.ComboBox();
            this.comboBoxXTLX = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBZ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDevice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRegInfo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(16, 299);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "生成许可文件";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "请选择要存放模板的目录";
            // 
            // btnSingleInfo
            // 
            this.btnSingleInfo.Location = new System.Drawing.Point(138, 299);
            this.btnSingleInfo.Name = "btnSingleInfo";
            this.btnSingleInfo.Size = new System.Drawing.Size(86, 23);
            this.btnSingleInfo.TabIndex = 10;
            this.btnSingleInfo.Text = "生成许可信息";
            this.btnSingleInfo.UseVisualStyleBackColor = true;
            this.btnSingleInfo.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboBoxBB);
            this.panel1.Controls.Add(this.comboBoxXTLX);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxBZ);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxUser);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxDevice);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxDays);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxDT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 221);
            this.panel1.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 40;
            this.label9.Tag = "";
            this.label9.Text = "版本：";
            // 
            // comboBoxBB
            // 
            this.comboBoxBB.FormattingEnabled = true;
            this.comboBoxBB.Items.AddRange(new object[] {
            "精简版",
            "完整版",
            "定制版",
            "测试(精简版)",
            "测试(完整版)",
            "测试(定制版)",
            "演示(精简版)",
            "演示(完整版)",
            "演示(定制版)"});
            this.comboBoxBB.Location = new System.Drawing.Point(84, 132);
            this.comboBoxBB.Name = "comboBoxBB";
            this.comboBoxBB.Size = new System.Drawing.Size(245, 20);
            this.comboBoxBB.TabIndex = 39;
            this.comboBoxBB.Text = "完整版";
            // 
            // comboBoxXTLX
            // 
            this.comboBoxXTLX.FormattingEnabled = true;
            this.comboBoxXTLX.Items.AddRange(new object[] {
            "国土监察系统",
            "农村土地发证",
            "触摸屏查询系统",
            "评价器管理系统"});
            this.comboBoxXTLX.Location = new System.Drawing.Point(85, 103);
            this.comboBoxXTLX.Name = "comboBoxXTLX";
            this.comboBoxXTLX.Size = new System.Drawing.Size(244, 20);
            this.comboBoxXTLX.TabIndex = 38;
            this.comboBoxXTLX.Text = "触摸屏查询系统";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 37;
            this.label8.Text = "系统类型：";
            // 
            // textBoxBZ
            // 
            this.textBoxBZ.Location = new System.Drawing.Point(85, 193);
            this.textBoxBZ.Name = "textBoxBZ";
            this.textBoxBZ.Size = new System.Drawing.Size(245, 21);
            this.textBoxBZ.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 35;
            this.label7.Text = "备注：";
            // 
            // textBoxUser
            // 
            this.textBoxUser.ForeColor = System.Drawing.Color.Red;
            this.textBoxUser.FormattingEnabled = true;
            this.textBoxUser.Location = new System.Drawing.Point(84, 40);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(245, 20);
            this.textBoxUser.TabIndex = 34;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.ForeColor = System.Drawing.Color.Red;
            this.numericUpDown1.Location = new System.Drawing.Point(270, 8);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 21);
            this.numericUpDown1.TabIndex = 33;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "序号：";
            // 
            // textBoxDevice
            // 
            this.textBoxDevice.Location = new System.Drawing.Point(85, 161);
            this.textBoxDevice.Name = "textBoxDevice";
            this.textBoxDevice.Size = new System.Drawing.Size(245, 21);
            this.textBoxDevice.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 29;
            this.label6.Text = "硬件序列号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "期限：";
            // 
            // textBoxDays
            // 
            this.textBoxDays.Location = new System.Drawing.Point(272, 71);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.Size = new System.Drawing.Size(57, 21);
            this.textBoxDays.TabIndex = 25;
            this.textBoxDays.Text = "30";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(84, 8);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(128, 21);
            this.textBoxID.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "许可证编号：";
            // 
            // textBoxDT
            // 
            this.textBoxDT.Location = new System.Drawing.Point(84, 71);
            this.textBoxDT.Name = "textBoxDT";
            this.textBoxDT.Size = new System.Drawing.Size(127, 21);
            this.textBoxDT.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "日期：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "用户名称：";
            // 
            // textBoxRegInfo
            // 
            this.textBoxRegInfo.Location = new System.Drawing.Point(12, 239);
            this.textBoxRegInfo.Multiline = true;
            this.textBoxRegInfo.Name = "textBoxRegInfo";
            this.textBoxRegInfo.Size = new System.Drawing.Size(334, 54);
            this.textBoxRegInfo.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "打开许可文件";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // FrmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 358);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSingleInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBoxRegInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户信息";
            this.Load += new System.EventHandler(this.FrmUserInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSingleInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxDevice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDays;
        private System.Windows.Forms.TextBox textBoxRegInfo;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxBZ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxXTLX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxBB;
        private System.Windows.Forms.Label label9;
    }
}