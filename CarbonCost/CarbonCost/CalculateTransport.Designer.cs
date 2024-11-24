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
            pictureBox1 = new PictureBox();
            cbFlight = new CheckBox();
            cbShipping = new CheckBox();
            cbVehicle = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._7_calculator_png_image;
            pictureBox1.Location = new Point(39, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // cbFlight
            // 
            cbFlight.AutoSize = true;
            cbFlight.Location = new Point(363, 101);
            cbFlight.Name = "cbFlight";
            cbFlight.Size = new Size(56, 19);
            cbFlight.TabIndex = 9;
            cbFlight.Text = "Flight";
            cbFlight.UseVisualStyleBackColor = true;
            // 
            // cbShipping
            // 
            cbShipping.AutoSize = true;
            cbShipping.Location = new Point(451, 101);
            cbShipping.Name = "cbShipping";
            cbShipping.Size = new Size(73, 19);
            cbShipping.TabIndex = 10;
            cbShipping.Text = "Shipping";
            cbShipping.UseVisualStyleBackColor = true;
            // 
            // cbVehicle
            // 
            cbVehicle.AutoSize = true;
            cbVehicle.Location = new Point(561, 101);
            cbVehicle.Name = "cbVehicle";
            cbVehicle.Size = new Size(63, 19);
            cbVehicle.TabIndex = 11;
            cbVehicle.Text = "Vehicle";
            cbVehicle.UseVisualStyleBackColor = true;
            // 
            // CalculateTransport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbVehicle);
            Controls.Add(cbShipping);
            Controls.Add(cbFlight);
            Controls.Add(pictureBox1);
            Name = "CalculateTransport";
            Text = "Calculate Transport";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private CheckBox cbFlight;
        private CheckBox cbShipping;
        private CheckBox cbVehicle;
    }
}