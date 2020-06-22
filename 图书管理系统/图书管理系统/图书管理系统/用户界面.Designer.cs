namespace 图书管理系统
{
    partial class frmUser
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
            this.lblContent = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.lblBookNameForSearch = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.btnSearchByKind = new System.Windows.Forms.Button();
            this.cmbKind = new System.Windows.Forms.ComboBox();
            this.lblKind = new System.Windows.Forms.Label();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.stuUser = new System.Windows.Forms.StatusStrip();
            this.作者 = new System.Windows.Forms.ToolStripStatusLabel();
            this.班级 = new System.Windows.Forms.ToolStripStatusLabel();
            this.学号 = new System.Windows.Forms.ToolStripStatusLabel();
            this.联系方式 = new System.Windows.Forms.ToolStripStatusLabel();
            this.系统时间 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.stuUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblContent.Location = new System.Drawing.Point(16, 321);
            this.lblContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(130, 24);
            this.lblContent.TabIndex = 22;
            this.lblContent.Text = "内容摘要：";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(21, 350);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(966, 192);
            this.txtContent.TabIndex = 21;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(532, 24);
            this.btnSearchBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(98, 32);
            this.btnSearchBook.TabIndex = 20;
            this.btnSearchBook.Text = "查找";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // lblBookNameForSearch
            // 
            this.lblBookNameForSearch.AutoSize = true;
            this.lblBookNameForSearch.Location = new System.Drawing.Point(26, 30);
            this.lblBookNameForSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookNameForSearch.Name = "lblBookNameForSearch";
            this.lblBookNameForSearch.Size = new System.Drawing.Size(98, 18);
            this.lblBookNameForSearch.TabIndex = 19;
            this.lblBookNameForSearch.Text = "图书书名：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 24);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(390, 28);
            this.txtName.TabIndex = 18;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(21, 66);
            this.dgvBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersWidth = 62;
            this.dgvBooks.RowTemplate.Height = 23;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(968, 250);
            this.dgvBooks.TabIndex = 17;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
            // 
            // btnSearchByKind
            // 
            this.btnSearchByKind.Location = new System.Drawing.Point(894, 24);
            this.btnSearchByKind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchByKind.Name = "btnSearchByKind";
            this.btnSearchByKind.Size = new System.Drawing.Size(94, 30);
            this.btnSearchByKind.TabIndex = 16;
            this.btnSearchByKind.Text = "按类查找";
            this.btnSearchByKind.UseVisualStyleBackColor = true;
            this.btnSearchByKind.Click += new System.EventHandler(this.btnSearchByKind_Click);
            // 
            // cmbKind
            // 
            this.cmbKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKind.FormattingEnabled = true;
            this.cmbKind.Location = new System.Drawing.Point(746, 26);
            this.cmbKind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbKind.Name = "cmbKind";
            this.cmbKind.Size = new System.Drawing.Size(138, 26);
            this.cmbKind.TabIndex = 15;
            // 
            // lblKind
            // 
            this.lblKind.AutoSize = true;
            this.lblKind.Location = new System.Drawing.Point(639, 30);
            this.lblKind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKind.Name = "lblKind";
            this.lblKind.Size = new System.Drawing.Size(98, 18);
            this.lblKind.TabIndex = 14;
            this.lblKind.Text = "书籍类别：";
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(21, 552);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(195, 56);
            this.btnBorrow.TabIndex = 23;
            this.btnBorrow.Text = "借书";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(794, 552);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(195, 56);
            this.btnQuery.TabIndex = 24;
            this.btnQuery.Text = "查看借书记录";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(406, 552);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(195, 56);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // stuUser
            // 
            this.stuUser.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.stuUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.作者,
            this.班级,
            this.学号,
            this.联系方式,
            this.系统时间});
            this.stuUser.Location = new System.Drawing.Point(0, 629);
            this.stuUser.Name = "stuUser";
            this.stuUser.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.stuUser.Size = new System.Drawing.Size(1010, 31);
            this.stuUser.TabIndex = 28;
            // 
            // 作者
            // 
            this.作者.Name = "作者";
            this.作者.Size = new System.Drawing.Size(118, 24);
            this.作者.Text = "作者：严文彬";
            // 
            // 班级
            // 
            this.班级.Name = "班级";
            this.班级.Size = new System.Drawing.Size(213, 24);
            this.班级.Text = "班级：183软件工程";
            // 
            // 学号
            // 
            this.学号.Name = "学号";
            this.学号.Size = new System.Drawing.Size(174, 24);
            this.学号.Text = "学号：7023118170";
            this.学号.Click += new System.EventHandler(this.学号_Click);
            // 
            // 联系方式
            // 
            this.联系方式.Name = "联系方式";
            this.联系方式.Size = new System.Drawing.Size(221, 24);
            this.联系方式.Text = "手机号码：10086";
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
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 660);
            this.Controls.Add(this.stuUser);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.lblBookNameForSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.btnSearchByKind);
            this.Controls.Add(this.cmbKind);
            this.Controls.Add(this.lblKind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUser_FormClosing);
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.stuUser.ResumeLayout(false);
            this.stuUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Label lblBookNameForSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btnSearchByKind;
        private System.Windows.Forms.ComboBox cmbKind;
        private System.Windows.Forms.Label lblKind;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip stuUser;
        private System.Windows.Forms.ToolStripStatusLabel 作者;
        private System.Windows.Forms.ToolStripStatusLabel 班级;
        private System.Windows.Forms.ToolStripStatusLabel 学号;
        private System.Windows.Forms.ToolStripStatusLabel 联系方式;
        private System.Windows.Forms.ToolStripStatusLabel 系统时间;
        private System.Windows.Forms.Timer timer1;

    }
}