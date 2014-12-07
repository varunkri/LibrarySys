namespace LibraryApp
{
    partial class LibrarianMenu
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
            this.addLibBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.searchBookBtn = new System.Windows.Forms.Button();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.blBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addLibBtn
            // 
            this.addLibBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLibBtn.Location = new System.Drawing.Point(224, 46);
            this.addLibBtn.Name = "addLibBtn";
            this.addLibBtn.Size = new System.Drawing.Size(218, 37);
            this.addLibBtn.TabIndex = 0;
            this.addLibBtn.TabStop = false;
            this.addLibBtn.Text = "Add a new librarian";
            this.addLibBtn.UseVisualStyleBackColor = true;
            this.addLibBtn.Click += new System.EventHandler(this.addLibBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.blBtn);
            this.groupBox1.Controls.Add(this.reportsBtn);
            this.groupBox1.Controls.Add(this.searchBookBtn);
            this.groupBox1.Controls.Add(this.addBookBtn);
            this.groupBox1.Controls.Add(this.addLibBtn);
            this.groupBox1.Location = new System.Drawing.Point(67, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 390);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Librarian Menu";
            // 
            // reportsBtn
            // 
            this.reportsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsBtn.Location = new System.Drawing.Point(224, 207);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(218, 37);
            this.reportsBtn.TabIndex = 3;
            this.reportsBtn.TabStop = false;
            this.reportsBtn.Text = "View reports";
            this.reportsBtn.UseVisualStyleBackColor = true;
            // 
            // searchBookBtn
            // 
            this.searchBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBookBtn.Location = new System.Drawing.Point(224, 155);
            this.searchBookBtn.Name = "searchBookBtn";
            this.searchBookBtn.Size = new System.Drawing.Size(218, 37);
            this.searchBookBtn.TabIndex = 2;
            this.searchBookBtn.TabStop = false;
            this.searchBookBtn.Text = "Search books";
            this.searchBookBtn.UseVisualStyleBackColor = true;
            this.searchBookBtn.Click += new System.EventHandler(this.searchBookBtn_Click);
            // 
            // addBookBtn
            // 
            this.addBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookBtn.Location = new System.Drawing.Point(224, 100);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(218, 37);
            this.addBookBtn.TabIndex = 1;
            this.addBookBtn.TabStop = false;
            this.addBookBtn.Text = "Add a book";
            this.addBookBtn.UseVisualStyleBackColor = true;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // blBtn
            // 
            this.blBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blBtn.Location = new System.Drawing.Point(224, 320);
            this.blBtn.Name = "blBtn";
            this.blBtn.Size = new System.Drawing.Size(218, 37);
            this.blBtn.TabIndex = 4;
            this.blBtn.TabStop = false;
            this.blBtn.Text = "Blacklist Customer";
            this.blBtn.UseVisualStyleBackColor = true;
            // 
            // LibrarianMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBox1);
            this.Name = "LibrarianMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibrarianMenu";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addLibBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchBookBtn;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Button blBtn;
    }
}