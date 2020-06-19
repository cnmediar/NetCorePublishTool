namespace NetCorePublishTool
{
    partial class FormNCorePub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNCorePub));
            this.btnSelectSourcePath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPubMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutPath = new System.Windows.Forms.TextBox();
            this.cmbRuntime = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFrameworks = new System.Windows.Forms.ComboBox();
            this.ckbRuntime = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPubNow = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.linkDoc = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbProjectPath = new System.Windows.Forms.ComboBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnCMD = new System.Windows.Forms.Button();
            this.txtCMD = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectSourcePath
            // 
            this.btnSelectSourcePath.Location = new System.Drawing.Point(601, 24);
            this.btnSelectSourcePath.Name = "btnSelectSourcePath";
            this.btnSelectSourcePath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectSourcePath.TabIndex = 0;
            this.btnSelectSourcePath.Text = "选择";
            this.btnSelectSourcePath.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "项目目录(.csproj文件,输入目录将检测是否存在项目文件)";
            // 
            // cmbPubMode
            // 
            this.cmbPubMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPubMode.FormattingEnabled = true;
            this.cmbPubMode.Items.AddRange(new object[] {
            "Release",
            "Debug"});
            this.cmbPubMode.Location = new System.Drawing.Point(62, 97);
            this.cmbPubMode.Name = "cmbPubMode";
            this.cmbPubMode.Size = new System.Drawing.Size(104, 20);
            this.cmbPubMode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "发布路径";
            // 
            // txtOutPath
            // 
            this.txtOutPath.Location = new System.Drawing.Point(8, 67);
            this.txtOutPath.Name = "txtOutPath";
            this.txtOutPath.Size = new System.Drawing.Size(289, 21);
            this.txtOutPath.TabIndex = 8;
            // 
            // cmbRuntime
            // 
            this.cmbRuntime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRuntime.FormattingEnabled = true;
            this.cmbRuntime.Location = new System.Drawing.Point(274, 97);
            this.cmbRuntime.Name = "cmbRuntime";
            this.cmbRuntime.Size = new System.Drawing.Size(120, 20);
            this.cmbRuntime.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "目标框架";
            // 
            // cmbFrameworks
            // 
            this.cmbFrameworks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrameworks.FormattingEnabled = true;
            this.cmbFrameworks.Location = new System.Drawing.Point(462, 98);
            this.cmbFrameworks.Name = "cmbFrameworks";
            this.cmbFrameworks.Size = new System.Drawing.Size(121, 20);
            this.cmbFrameworks.TabIndex = 12;
            // 
            // ckbRuntime
            // 
            this.ckbRuntime.AutoSize = true;
            this.ckbRuntime.Location = new System.Drawing.Point(194, 99);
            this.ckbRuntime.Name = "ckbRuntime";
            this.ckbRuntime.Size = new System.Drawing.Size(84, 16);
            this.ckbRuntime.TabIndex = 14;
            this.ckbRuntime.Text = "发布运行时";
            this.ckbRuntime.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "发布模式";
            // 
            // btnPubNow
            // 
            this.btnPubNow.Location = new System.Drawing.Point(602, 66);
            this.btnPubNow.Name = "btnPubNow";
            this.btnPubNow.Size = new System.Drawing.Size(99, 35);
            this.btnPubNow.TabIndex = 18;
            this.btnPubNow.Text = "立即发布";
            this.btnPubNow.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "注:目标框架需要配置TargetFramework(s),详情查看:";
            // 
            // linkDoc
            // 
            this.linkDoc.AutoSize = true;
            this.linkDoc.Location = new System.Drawing.Point(296, 5);
            this.linkDoc.Name = "linkDoc";
            this.linkDoc.Size = new System.Drawing.Size(359, 12);
            this.linkDoc.TabIndex = 20;
            this.linkDoc.TabStop = true;
            this.linkDoc.Text = "https://docs.microsoft.com/en-us/dotnet/standard/frameworks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(437, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "注:工具只负责拼接发布命令,所有执行操作均为.NetCore SDK,目前只支持2.x版本";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.txtCMD);
            this.panel2.Controls.Add(this.btnCMD);
            this.panel2.Controls.Add(this.btnUpload);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtUser);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtHost);
            this.panel2.Controls.Add(this.cmbProjectPath);
            this.panel2.Controls.Add(this.btnPubNow);
            this.panel2.Controls.Add(this.btnSelectSourcePath);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbPubMode);
            this.panel2.Controls.Add(this.txtOutPath);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbRuntime);
            this.panel2.Controls.Add(this.ckbRuntime);
            this.panel2.Controls.Add(this.cmbFrameworks);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 206);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(713, 430);
            this.panel3.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtLog);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(12, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(689, 430);
            this.panel6.TabIndex = 3;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(689, 430);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(12, 430);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(701, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(12, 430);
            this.panel4.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.linkDoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 636);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 38);
            this.panel1.TabIndex = 22;
            // 
            // cmbProjectPath
            // 
            this.cmbProjectPath.FormattingEnabled = true;
            this.cmbProjectPath.Location = new System.Drawing.Point(12, 24);
            this.cmbProjectPath.Name = "cmbProjectPath";
            this.cmbProjectPath.Size = new System.Drawing.Size(555, 20);
            this.cmbProjectPath.TabIndex = 19;
            this.cmbProjectPath.SelectedIndexChanged += new System.EventHandler(this.cmbProjectPath_SelectedIndexChanged);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(62, 134);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(120, 21);
            this.txtHost.TabIndex = 20;
            this.txtHost.Text = "192.168.31.12";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "服务器";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "密码";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(256, 134);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(120, 21);
            this.txtUser.TabIndex = 21;
            this.txtUser.Text = "root";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(210, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "用户名";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(456, 135);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(120, 21);
            this.txtPassword.TabIndex = 22;
            this.txtPassword.Text = "flying10012";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(600, 118);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(100, 31);
            this.btnUpload.TabIndex = 25;
            this.btnUpload.Text = "上传文件";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // btnCMD
            // 
            this.btnCMD.Location = new System.Drawing.Point(601, 163);
            this.btnCMD.Name = "btnCMD";
            this.btnCMD.Size = new System.Drawing.Size(102, 30);
            this.btnCMD.TabIndex = 26;
            this.btnCMD.Text = "执行远程命令";
            this.btnCMD.UseVisualStyleBackColor = true;
            this.btnCMD.Click += new System.EventHandler(this.btnCMD_Click);
            // 
            // txtCMD
            // 
            this.txtCMD.Location = new System.Drawing.Point(53, 170);
            this.txtCMD.Name = "txtCMD";
            this.txtCMD.Size = new System.Drawing.Size(500, 21);
            this.txtCMD.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(316, 67);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(251, 21);
            this.textBox6.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(311, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 28;
            this.label10.Text = "远程路径";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 29;
            this.label11.Text = "命 令";
            // 
            // FormNCorePub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 674);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNCorePub";
            this.Text = "NCorePub  by.玩双截棍的熊猫";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectSourcePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPubMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOutPath;
        private System.Windows.Forms.ComboBox cmbRuntime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFrameworks;
        private System.Windows.Forms.CheckBox ckbRuntime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPubNow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkDoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbProjectPath;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtCMD;
        private System.Windows.Forms.Button btnCMD;
        private System.Windows.Forms.Label label11;
    }
}