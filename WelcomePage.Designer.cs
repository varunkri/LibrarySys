namespace LibraryApp
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.welcomLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.libLogin = new System.Windows.Forms.Button();
            this.cusEmail = new System.Windows.Forms.TextBox();
            this.newCustomerLabel = new System.Windows.Forms.Label();
            this.cusPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.libUsername = new System.Windows.Forms.TextBox();
            this.libPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomLabel
            // 
            this.welcomLabel.AutoSize = true;
            this.welcomLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.welcomLabel.Location = new System.Drawing.Point(40, 194);
            this.welcomLabel.Name = "welcomLabel";
            this.welcomLabel.Size = new System.Drawing.Size(708, 55);
            this.welcomLabel.TabIndex = 0;
            this.welcomLabel.Text = "Welcome to Long Beach Library";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // libLogin
            // 
            this.libLogin.Location = new System.Drawing.Point(235, 149);
            this.libLogin.Name = "libLogin";
            this.libLogin.Size = new System.Drawing.Size(75, 23);
            this.libLogin.TabIndex = 9;
            this.libLogin.Text = "Login";
            this.libLogin.UseVisualStyleBackColor = true;
            this.libLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // cusEmail
            // 
            this.cusEmail.ForeColor = System.Drawing.Color.Black;
            this.cusEmail.Location = new System.Drawing.Point(6, 58);
            this.cusEmail.Name = "cusEmail";
            this.cusEmail.Size = new System.Drawing.Size(304, 20);
            this.cusEmail.TabIndex = 0;
            // 
            // newCustomerLabel
            // 
            this.newCustomerLabel.AutoSize = true;
            this.newCustomerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustomerLabel.Location = new System.Drawing.Point(3, 150);
            this.newCustomerLabel.Name = "newCustomerLabel";
            this.newCustomerLabel.Size = new System.Drawing.Size(158, 18);
            this.newCustomerLabel.TabIndex = 8;
            this.newCustomerLabel.Text = "New customer register";
            this.newCustomerLabel.Click += new System.EventHandler(this.newCustomerLabel_Click);
            // 
            // cusPassword
            // 
            this.cusPassword.ForeColor = System.Drawing.Color.Black;
            this.cusPassword.Location = new System.Drawing.Point(6, 110);
            this.cusPassword.Name = "cusPassword";
            this.cusPassword.Size = new System.Drawing.Size(304, 20);
            this.cusPassword.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cusEmail);
            this.groupBox1.Controls.Add(this.cusPassword);
            this.groupBox1.Controls.Add(this.libLogin);
            this.groupBox1.Controls.Add(this.newCustomerLabel);
            this.groupBox1.Location = new System.Drawing.Point(50, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 178);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.libUsername);
            this.groupBox2.Controls.Add(this.libPassword);
            this.groupBox2.Location = new System.Drawing.Point(416, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 178);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Librarian Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Username";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // libUsername
            // 
            this.libUsername.ForeColor = System.Drawing.Color.Black;
            this.libUsername.Location = new System.Drawing.Point(6, 58);
            this.libUsername.Name = "libUsername";
            this.libUsername.Size = new System.Drawing.Size(304, 20);
            this.libUsername.TabIndex = 3;
            // 
            // libPassword
            // 
            this.libPassword.ForeColor = System.Drawing.Color.Black;
            this.libPassword.Location = new System.Drawing.Point(6, 110);
            this.libPassword.Name = "libPassword";
            this.libPassword.Size = new System.Drawing.Size(304, 20);
            this.libPassword.TabIndex = 4;
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.welcomLabel);
            this.Name = "WelcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomePage";
            this.Load += new System.EventHandler(this.WelcomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button libLogin;
        private System.Windows.Forms.TextBox cusEmail;
        private System.Windows.Forms.Label newCustomerLabel;
        private System.Windows.Forms.TextBox cusPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox libUsername;
        private System.Windows.Forms.TextBox libPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}