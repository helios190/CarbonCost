namespace CarbonCost
{
    partial class homepage
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
            label1 = new Label();
            button1 = new Button();
            tbPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbUsername = new TextBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(502, 354);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 0;
            label1.Text = "Do not have an Account ? ";
            // 
            // button1
            // 
            button1.Location = new Point(457, 275);
            button1.Name = "button1";
            button1.Size = new Size(301, 35);
            button1.TabIndex = 1;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(457, 219);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(301, 23);
            tbPassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(457, 201);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(457, 132);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(457, 150);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(301, 23);
            tbUsername.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.R;
            pictureBox2.Location = new Point(28, 54);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(386, 351);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(679, 421);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Heavy", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(457, 54);
            label5.Name = "label5";
            label5.Size = new Size(301, 61);
            label5.TabIndex = 9;
            label5.Text = "Carbon Cost";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(641, 354);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(77, 15);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register Now";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(tbUsername);
            Controls.Add(label2);
            Controls.Add(tbPassword);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "homepage";
            Text = "homepage";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox tbPassword;
        private Label label2;
        private Label label3;
        private TextBox tbUsername;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
        private LinkLabel linkLabel1;
    }
}