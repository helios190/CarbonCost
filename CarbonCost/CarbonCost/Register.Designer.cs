namespace CarbonCost
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            label3 = new Label();
            tbUsername = new TextBox();
            label2 = new Label();
            tbPassword = new TextBox();
            btnRegister = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            lblName = new Label();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(466, 173);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 10;
            label3.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(466, 191);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(301, 23);
            tbUsername.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(466, 241);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(466, 259);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(301, 23);
            tbPassword.TabIndex = 7;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(596, 377);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(68, 23);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(466, 305);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 12;
            label1.Text = "Confirm Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(466, 323);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 23);
            textBox1.TabIndex = 11;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(466, 105);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 14;
            lblName.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(466, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(301, 23);
            textBox2.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-72, -32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(509, 505);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(526, 68);
            label4.Name = "label4";
            label4.Size = new Size(217, 25);
            label4.TabIndex = 16;
            label4.Text = "Register your company!";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(lblName);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(tbUsername);
            Controls.Add(label2);
            Controls.Add(tbPassword);
            Controls.Add(btnRegister);
            Name = "Register";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox tbUsername;
        private Label label2;
        private TextBox tbPassword;
        private Button btnRegister;
        private Label label1;
        private TextBox textBox1;
        private Label lblName;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Label label4;
    }
}