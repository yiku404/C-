namespace 图书管理系统
{
    partial class frmAddBook
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
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtPress = new System.Windows.Forms.TextBox();
            this.txtBookKind = new System.Windows.Forms.TextBox();
            this.lblPress = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblBookKind = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.stuAddBook = new System.Windows.Forms.StatusStrip();
            this.作者 = new System.Windows.Forms.ToolStripStatusLabel();
            this.系统时间 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stuAddBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(158, 33);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(320, 28);
            this.txtBookName.TabIndex = 39;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(158, 74);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(320, 28);
            this.txtAuthor.TabIndex = 38;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(158, 154);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(320, 28);
            this.txtTime.TabIndex = 37;
            // 
            // txtPress
            // 
            this.txtPress.Location = new System.Drawing.Point(154, 195);
            this.txtPress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPress.Name = "txtPress";
            this.txtPress.Size = new System.Drawing.Size(324, 28);
            this.txtPress.TabIndex = 36;
            // 
            // txtBookKind
            // 
            this.txtBookKind.Location = new System.Drawing.Point(154, 114);
            this.txtBookKind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBookKind.Name = "txtBookKind";
            this.txtBookKind.Size = new System.Drawing.Size(324, 28);
            this.txtBookKind.TabIndex = 35;
            // 
            // lblPress
            // 
            this.lblPress.AutoSize = true;
            this.lblPress.Location = new System.Drawing.Point(51, 200);
            this.lblPress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(80, 18);
            this.lblPress.TabIndex = 34;
            this.lblPress.Text = "出版社：";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(51, 159);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(98, 18);
            this.lblTime.TabIndex = 33;
            this.lblTime.Text = "出版时间：";
            // 
            // lblBookKind
            // 
            this.lblBookKind.AutoSize = true;
            this.lblBookKind.Location = new System.Drawing.Point(51, 118);
            this.lblBookKind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookKind.Name = "lblBookKind";
            this.lblBookKind.Size = new System.Drawing.Size(98, 18);
            this.lblBookKind.TabIndex = 32;
            this.lblBookKind.Text = "图书类别：";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(69, 78);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(62, 18);
            this.lblAuthor.TabIndex = 31;
            this.lblAuthor.Text = "作者：";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(69, 38);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(62, 18);
            this.lblBookName.TabIndex = 30;
            this.lblBookName.Text = "书名：";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Location = new System.Drawing.Point(51, 246);
            this.lblContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(98, 18);
            this.lblContent.TabIndex = 29;
            this.lblContent.Text = "内容摘要：";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(54, 284);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(424, 192);
            this.txtContent.TabIndex = 27;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(54, 486);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(141, 58);
            this.btnAddBook.TabIndex = 25;
            this.btnAddBook.Text = "确认添加";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(339, 486);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(141, 58);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // stuAddBook
            // 
            this.stuAddBook.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.stuAddBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.作者,
            this.系统时间});
            this.stuAddBook.Location = new System.Drawing.Point(0, 553);
            this.stuAddBook.Name = "stuAddBook";
            this.stuAddBook.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.stuAddBook.Size = new System.Drawing.Size(531, 31);
            this.stuAddBook.TabIndex = 43;
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
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 584);
            this.Controls.Add(this.stuAddBook);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtPress);
            this.Controls.Add(this.txtBookKind);
            this.Controls.Add(this.lblPress);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblBookKind);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnAddBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmAddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增书目";
            this.stuAddBook.ResumeLayout(false);
            this.stuAddBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtPress;
        private System.Windows.Forms.TextBox txtBookKind;
        private System.Windows.Forms.Label lblPress;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblBookKind;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.StatusStrip stuAddBook;
        private System.Windows.Forms.ToolStripStatusLabel 作者;
        private System.Windows.Forms.ToolStripStatusLabel 系统时间;
        private System.Windows.Forms.Timer timer1;
    }
}