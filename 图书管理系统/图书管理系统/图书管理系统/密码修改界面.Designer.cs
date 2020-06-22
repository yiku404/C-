namespace 图书管理系统
{
    partial class frmModifyPwd
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwdAgain = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.lblNewPwdAgain = new System.Windows.Forms.Label();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.stuModifyPwd = new System.Windows.Forms.StatusStrip();
            this.作者 = new System.Windows.Forms.ToolStripStatusLabel();
            this.系统时间 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stuModifyPwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(190, 68);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 28);
            this.txtName.TabIndex = 0;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(190, 108);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(148, 28);
            this.txtPwd.TabIndex = 1;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(190, 148);
            this.txtNewPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(148, 28);
            this.txtNewPwd.TabIndex = 2;
            // 
            // txtNewPwdAgain
            // 
            this.txtNewPwdAgain.Location = new System.Drawing.Point(190, 189);
            this.txtNewPwdAgain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewPwdAgain.Name = "txtNewPwdAgain";
            this.txtNewPwdAgain.PasswordChar = '*';
            this.txtNewPwdAgain.Size = new System.Drawing.Size(148, 28);
            this.txtNewPwdAgain.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(75, 282);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 34);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确认修改";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(228, 282);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "返回";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(72, 72);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 18);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "用户名:";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(72, 122);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(53, 18);
            this.lblPwd.TabIndex = 7;
            this.lblPwd.Text = "密码:";
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.AutoSize = true;
            this.lblNewPwd.Location = new System.Drawing.Point(72, 162);
            this.lblNewPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(71, 18);
            this.lblNewPwd.TabIndex = 8;
            this.lblNewPwd.Text = "新密码:";
            // 
            // lblNewPwdAgain
            // 
            this.lblNewPwdAgain.AutoSize = true;
            this.lblNewPwdAgain.Location = new System.Drawing.Point(72, 194);
            this.lblNewPwdAgain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewPwdAgain.Name = "lblNewPwdAgain";
            this.lblNewPwdAgain.Size = new System.Drawing.Size(107, 18);
            this.lblNewPwdAgain.TabIndex = 9;
            this.lblNewPwdAgain.Text = "确认新密码:";
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.ForeColor = System.Drawing.Color.Red;
            this.lblPrompt.Location = new System.Drawing.Point(75, 237);
            this.lblPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(62, 18);
            this.lblPrompt.TabIndex = 10;
            this.lblPrompt.Text = "提示：";
            this.lblPrompt.Visible = false;
            // 
            // stuModifyPwd
            // 
            this.stuModifyPwd.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.stuModifyPwd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.作者,
            this.系统时间});
            this.stuModifyPwd.Location = new System.Drawing.Point(0, 395);
            this.stuModifyPwd.Name = "stuModifyPwd";
            this.stuModifyPwd.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.stuModifyPwd.Size = new System.Drawing.Size(412, 31);
            this.stuModifyPwd.TabIndex = 30;
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
            // frmModifyPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 426);
            this.Controls.Add(this.stuModifyPwd);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.lblNewPwdAgain);
            this.Controls.Add(this.lblNewPwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNewPwdAgain);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmModifyPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码修改";
            this.stuModifyPwd.ResumeLayout(false);
            this.stuModifyPwd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.TextBox txtNewPwdAgain;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.Label lblNewPwdAgain;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.StatusStrip stuModifyPwd;
        private System.Windows.Forms.ToolStripStatusLabel 作者;
        private System.Windows.Forms.ToolStripStatusLabel 系统时间;
        private System.Windows.Forms.Timer timer1;
    }
}