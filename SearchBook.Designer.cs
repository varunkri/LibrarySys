namespace LibraryApp
{
    partial class SearchBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tipsPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isbnText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.authorText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bookList = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availablebool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.tipsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tipsPanel);
            this.groupBox1.Controls.Add(this.isbnText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.authorText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.titleText);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Book";
            // 
            // tipsPanel
            // 
            this.tipsPanel.Controls.Add(this.label5);
            this.tipsPanel.Controls.Add(this.label4);
            this.tipsPanel.Controls.Add(this.label3);
            this.tipsPanel.Location = new System.Drawing.Point(455, 19);
            this.tipsPanel.Name = "tipsPanel";
            this.tipsPanel.Size = new System.Drawing.Size(337, 88);
            this.tipsPanel.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Click on a cell and press delete to delete the row";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Click on a cell and press F12 to edit the value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "TIP: ";
            // 
            // isbnText
            // 
            this.isbnText.Location = new System.Drawing.Point(126, 121);
            this.isbnText.Name = "isbnText";
            this.isbnText.Size = new System.Drawing.Size(259, 20);
            this.isbnText.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ISBN";
            // 
            // authorText
            // 
            this.authorText.Location = new System.Drawing.Point(126, 77);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(259, 20);
            this.authorText.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Author";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(126, 39);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(259, 20);
            this.titleText.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(57, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Title";
            // 
            // bookList
            // 
            this.bookList.AllowUserToAddRows = false;
            this.bookList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.availablebool,
            this.author,
            this.genre,
            this.isbn,
            this.ID,
            this.Available,
            this.borrow});
            this.bookList.Location = new System.Drawing.Point(4, 214);
            this.bookList.Name = "bookList";
            this.bookList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookList.RowTemplate.Height = 30;
            this.bookList.Size = new System.Drawing.Size(924, 339);
            this.bookList.TabIndex = 1;
            this.bookList.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.bookList_CellBeginEdit);
            this.bookList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookList_CellContentClick);
            this.bookList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookList_CellEndEdit);
            this.bookList.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.bookList_UserDeletingRow);
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.FillWeight = 200F;
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.Width = 200;
            // 
            // availablebool
            // 
            this.availablebool.DataPropertyName = "available";
            this.availablebool.HeaderText = "available";
            this.availablebool.Name = "availablebool";
            this.availablebool.Visible = false;
            // 
            // author
            // 
            this.author.DataPropertyName = "author";
            this.author.HeaderText = "Author";
            this.author.Name = "author";
            this.author.Width = 150;
            // 
            // genre
            // 
            this.genre.DataPropertyName = "genre";
            this.genre.HeaderText = "Genre";
            this.genre.Name = "genre";
            this.genre.Width = 150;
            // 
            // isbn
            // 
            this.isbn.DataPropertyName = "isbn";
            this.isbn.HeaderText = "ISBN";
            this.isbn.Name = "isbn";
            this.isbn.Width = 150;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Available
            // 
            this.Available.DataPropertyName = "strAvailable";
            this.Available.HeaderText = "Available";
            this.Available.Name = "Available";
            // 
            // borrow
            // 
            this.borrow.HeaderText = "";
            this.borrow.Name = "borrow";
            this.borrow.Text = "Borrow";
            this.borrow.UseColumnTextForButtonValue = true;
            // 
            // SearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 577);
            this.Controls.Add(this.bookList);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchBook";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tipsPanel.ResumeLayout(false);
            this.tipsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView bookList;
        private System.Windows.Forms.TextBox isbnText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox authorText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel tipsPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn availablebool;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available;
        private System.Windows.Forms.DataGridViewButtonColumn borrow;
    }
}