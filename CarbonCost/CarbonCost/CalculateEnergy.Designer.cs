namespace CarbonCost
{
    partial class CalculateEnergy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEnergy = new Label();
            lblTransport = new Label();
            lblMetric = new Label();
            tbEnergy = new TextBox();
            tbTransport = new TextBox();
            tbMetric = new TextBox();
            btnCalculate = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblEnergy
            // 
            lblEnergy.AutoSize = true;
            lblEnergy.Location = new Point(360, 142);
            lblEnergy.Name = "lblEnergy";
            lblEnergy.Size = new Size(122, 15);
            lblEnergy.TabIndex = 0;
            lblEnergy.Text = "Energy Consumption:";
            // 
            // lblTransport
            // 
            lblTransport.AutoSize = true;
            lblTransport.Location = new Point(364, 174);
            lblTransport.Name = "lblTransport";
            lblTransport.Size = new Size(118, 15);
            lblTransport.TabIndex = 1;
            lblTransport.Text = "Transportation Habit:";
            // 
            // lblMetric
            // 
            lblMetric.AutoSize = true;
            lblMetric.Location = new Point(371, 210);
            lblMetric.Name = "lblMetric";
            lblMetric.Size = new Size(111, 15);
            lblMetric.TabIndex = 2;
            lblMetric.Text = "Production Metrics:";
            // 
            // tbEnergy
            // 
            tbEnergy.Location = new Point(488, 139);
            tbEnergy.Name = "tbEnergy";
            tbEnergy.Size = new Size(241, 23);
            tbEnergy.TabIndex = 3;
            // 
            // tbTransport
            // 
            tbTransport.Location = new Point(488, 171);
            tbTransport.Name = "tbTransport";
            tbTransport.Size = new Size(241, 23);
            tbTransport.TabIndex = 4;
            // 
            // tbMetric
            // 
            tbMetric.Location = new Point(488, 207);
            tbMetric.Name = "tbMetric";
            tbMetric.Size = new Size(241, 23);
            tbMetric.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(521, 252);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._7_calculator_png_image;
            pictureBox1.Location = new Point(96, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // CalculateEnergy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnCalculate);
            Controls.Add(tbMetric);
            Controls.Add(tbTransport);
            Controls.Add(tbEnergy);
            Controls.Add(lblMetric);
            Controls.Add(lblTransport);
            Controls.Add(lblEnergy);
            Name = "CalculateEnergy";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnergy;
        private Label lblTransport;
        private Label lblMetric;
        private TextBox tbEnergy;
        private TextBox tbTransport;
        private TextBox tbMetric;
        private Button btnCalculate;
        private PictureBox pictureBox1;
    }
}
