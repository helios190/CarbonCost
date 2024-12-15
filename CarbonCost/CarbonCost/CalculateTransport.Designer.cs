namespace CarbonCost
{
    partial class CalculateTransport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateTransport));
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGreen;
            label2.Location = new Point(568, -749);
            label2.Name = "label2";
            label2.Size = new Size(902, 2175);
            label2.TabIndex = 15;
            label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DarkGreen;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(570, 238);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(629, 515);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(82, 444);
            label3.Name = "label3";
            label3.Size = new Size(428, 90);
            label3.TabIndex = 17;
            label3.Text = "Calculate your most recent \r\nCarbon Emission Now!";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkGreen;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(125, 565);
            label5.Name = "label5";
            label5.Size = new Size(337, 84);
            label5.TabIndex = 19;
            label5.Text = "Calculating through 2 considerations:\r\n1.) Electricity Consumption\r\n2.) Travel Habits";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // CalculateTransport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1143, 750);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CalculateTransport";
            Text = "Calculate Transport";
            Load += CalculateTransport_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label5;
    }
}