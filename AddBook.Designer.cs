namespace LibraryApp.Classes
{
    partial class AddBook
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
            this.addBtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.genreText = new System.Windows.Forms.TextBox();
            this.isbnText = new System.Windows.Forms.TextBox();
            this.authorText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(268, 334);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(38, 75);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(27, 13);
            this.title.TabIndex = 1;
            this.title.Text = "Title";
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Location = new System.Drawing.Point(38, 120);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(38, 13);
            this.author.TabIndex = 2;
            this.author.Text = "Author";
            // 
            // isbn
            // 
            this.isbn.AutoSize = true;
            this.isbn.Location = new System.Drawing.Point(38, 162);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(32, 13);
            this.isbn.TabIndex = 3;
            this.isbn.Text = "ISBN";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Location = new System.Drawing.Point(38, 205);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(36, 13);
            this.genre.TabIndex = 4;
            this.genre.Text = "Genre";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(185, 72);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(259, 20);
            this.titleText.TabIndex = 5;
            // 
            // genreText
            // 
            this.genreText.Location = new System.Drawing.Point(185, 202);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(259, 20);
            this.genreText.TabIndex = 6;
            // 
            // isbnText
            // 
            this.isbnText.Location = new System.Drawing.Point(185, 159);
            this.isbnText.Name = "isbnText";
            this.isbnText.Size = new System.Drawing.Size(259, 20);
            this.isbnText.TabIndex = 7;
            // 
            // authorText
            // 
            this.authorText.Location = new System.Drawing.Point(185, 117);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(259, 20);
            this.authorText.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.authorText);
            this.groupBox1.Controls.Add(this.isbnText);
            this.groupBox1.Controls.Add(this.genreText);
            this.groupBox1.Controls.Add(this.titleText);
            this.groupBox1.Controls.Add(this.genre);
            this.groupBox1.Controls.Add(this.isbn);
            this.groupBox1.Controls.Add(this.author);
            this.groupBox1.Controls.Add(this.title);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Location = new System.Drawing.Point(48, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 390);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a Book";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBook";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label isbn;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox genreText;
        private System.Windows.Forms.TextBox isbnText;
        private System.Windows.Forms.TextBox authorText;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}