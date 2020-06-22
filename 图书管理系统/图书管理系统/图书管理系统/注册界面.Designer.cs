namespace 图书管理系统
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtPwdAgain = new System.Windows.Forms.TextBox();
            this.lblPwdAgain = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.pnlSex = new System.Windows.Forms.Panel();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.stuRegister = new System.Windows.Forms.StatusStrip();
            this.作者 = new System.Windows.Forms.ToolStripStatusLabel();
            this.系统时间 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlSex.SuspendLayout();
            this.stuRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(200, 81);
            this.txtNewName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(148, 28);
            this.txtNewName.TabIndex = 0;
            this.txtNewName.TextChanged += new System.EventHandler(this.txtNewName_TextChanged);
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(200, 207);
            this.txtNewPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(148, 28);
            this.txtNewPwd.TabIndex = 1;
            this.txtNewPwd.TextChanged += new System.EventHandler(this.txtNewPwd_TextChanged);
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(120, 86);
            this.lblNewName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(71, 18);
            this.lblNewName.TabIndex = 2;
            this.lblNewName.Text = "用户名:";
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.AutoSize = true;
            this.lblNewPwd.Location = new System.Drawing.Point(138, 212);
            this.lblNewPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(53, 18);
            this.lblNewPwd.TabIndex = 3;
            this.lblNewPwd.Text = "密码:";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(105, 386);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(112, 34);
            this.btnFinish.TabIndex = 4;
            this.btnFinish.Text = "提交";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(237, 386);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 34);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtPwdAgain
            // 
            this.txtPwdAgain.Location = new System.Drawing.Point(200, 270);
            this.txtPwdAgain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPwdAgain.Name = "txtPwdAgain";
            this.txtPwdAgain.PasswordChar = '*';
            this.txtPwdAgain.Size = new System.Drawing.Size(148, 28);
            this.txtPwdAgain.TabIndex = 6;
            this.txtPwdAgain.TextChanged += new System.EventHandler(this.txtPwdAgain_TextChanged);
            // 
            // lblPwdAgain
            // 
            this.lblPwdAgain.AutoSize = true;
            this.lblPwdAgain.Location = new System.Drawing.Point(102, 274);
            this.lblPwdAgain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwdAgain.Name = "lblPwdAgain";
            this.lblPwdAgain.Size = new System.Drawing.Size(89, 18);
            this.lblPwdAgain.TabIndex = 7;
            this.lblPwdAgain.Text = "确认密码:";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(4, 3);
            this.rbMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(51, 22);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "男";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(93, 3);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(51, 22);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.Text = "女";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // pnlSex
            // 
            this.pnlSex.Controls.Add(this.rbFemale);
            this.pnlSex.Controls.Add(this.rbMale);
            this.pnlSex.Location = new System.Drawing.Point(200, 144);
            this.pnlSex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSex.Name = "pnlSex";
            this.pnlSex.Size = new System.Drawing.Size(150, 32);
            this.pnlSex.TabIndex = 8;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(138, 150);
            this.lblSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(53, 18);
            this.lblSex.TabIndex = 9;
            this.lblSex.Text = "性别:";
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.ForeColor = System.Drawing.Color.Red;
            this.lblPrompt.Location = new System.Drawing.Point(129, 336);
            this.lblPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(62, 18);
            this.lblPrompt.TabIndex = 10;
            this.lblPrompt.Text = "提示：";
            this.lblPrompt.Visible = false;
            // 
            // stuRegister
            // 
            this.stuRegister.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.stuRegister.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.作者,
            this.系统时间});
            this.stuRegister.Location = new System.Drawing.Point(0, 479);
            this.stuRegister.Name = "stuRegister";
            this.stuRegister.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.stuRegister.Size = new System.Drawing.Size(496, 31);
            this.stuRegister.TabIndex = 32;
            // 
            // 作者
            // 
            this.作者.Name = "作者";
            this.作者.Size = new System.Drawing.Size(155, 24);
            this.作者.Text = "作者：严文彬";
            this.作者.Click += new System.EventHandler(this.作者_Click);
            // 
            // 系统时间
            // 
            this.系统时间.Name = "系统时间";
            this.系统时间.Size = new System.Drawing.Size(64, 24);
            this.系统时间.Text = "时间：";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 510);
            this.Controls.Add(this.stuRegister);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.pnlSex);
            this.Controls.Add(this.lblPwdAgain);
            this.Controls.Add(this.txtPwdAgain);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.lblNewPwd);
            this.Controls.Add(this.lblNewName);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.txtNewName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmRegister";
            this.Text = "注册";
            this.pnlSex.ResumeLayout(false);
            this.pnlSex.PerformLayout();
            this.stuRegister.ResumeLayout(false);
            this.stuRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtPwdAgain;
        private System.Windows.Forms.Label lblPwdAgain;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Panel pnlSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.StatusStrip stuRegister;
        private System.Windows.Forms.ToolStripStatusLabel 作者;
        private System.Windows.Forms.ToolStripStatusLabel 系统时间;
        private System.Windows.Forms.Timer timer1;
    }
}