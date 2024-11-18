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
        public void InitializeComponent()
        {
            lblUnits = new Label();
            lblState = new Label();
            btnCalculate = new Button();
            pictureBox1 = new PictureBox();
            lblCountry = new Label();
            lblEValue = new Label();
            cmbElectricityUnit = new ComboBox();
            cmbCountry = new ComboBox();
            cmbState = new ComboBox();
            txtElectricityValue = new TextBox();
            lblResult = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUnits
            // 
            lblUnits.AutoSize = true;
            lblUnits.Location = new Point(371, 108);
            lblUnits.Name = "lblUnits";
            lblUnits.Size = new Size(86, 15);
            lblUnits.TabIndex = 1;
            lblUnits.Text = "Electricity Unit:";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new Point(371, 210);
            lblState.Name = "lblState";
            lblState.Size = new Size(93, 15);
            lblState.TabIndex = 2;
            lblState.Text = "State (Optional):";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(521, 252);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Next";
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
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(371, 177);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(53, 15);
            lblCountry.TabIndex = 8;
            lblCountry.Text = "Country:";
            // 
            // lblEValue
            // 
            lblEValue.AutoSize = true;
            lblEValue.Location = new Point(371, 143);
            lblEValue.Name = "lblEValue";
            lblEValue.Size = new Size(92, 15);
            lblEValue.TabIndex = 9;
            lblEValue.Text = "Electricity Value:";
            // 
            // cmbElectricityUnit
            // 
            cmbElectricityUnit.FormattingEnabled = true;
            cmbElectricityUnit.Location = new Point(504, 105);
            cmbElectricityUnit.Name = "cmbElectricityUnit";
            cmbElectricityUnit.Size = new Size(121, 23);
            cmbElectricityUnit.TabIndex = 10;
            // 
            // cmbCountry
            // 
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(504, 174);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(121, 23);
            cmbCountry.TabIndex = 11;
            // 
            // cmbState
            // 
            cmbState.FormattingEnabled = true;
            cmbState.Location = new Point(504, 207);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(121, 23);
            cmbState.TabIndex = 12;
            // 
            // txtElectricityValue
            // 
            txtElectricityValue.Location = new Point(504, 140);
            txtElectricityValue.Name = "txtElectricityValue";
            txtElectricityValue.Size = new Size(121, 23);
            txtElectricityValue.TabIndex = 13;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(338, 373);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(42, 15);
            lblResult.TabIndex = 14;
            lblResult.Text = "Result:";
            // 
            // CalculateEnergy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(txtElectricityValue);
            Controls.Add(cmbState);
            Controls.Add(cmbCountry);
            Controls.Add(cmbElectricityUnit);
            Controls.Add(lblEValue);
            Controls.Add(lblCountry);
            Controls.Add(pictureBox1);
            Controls.Add(btnCalculate);
            Controls.Add(lblState);
            Controls.Add(lblUnits);
            Name = "CalculateEnergy";
            Text = "Calculate Energy";
            Load += CalculateEnergy_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label lblUnits;
        public Label lblState;
        public Button btnCalculate;
        public PictureBox pictureBox1;
        private Label lblCountry;
        public Label lblEValue;
        public ComboBox cmbElectricityUnit;
        public ComboBox cmbCountry;
        public ComboBox cmbState;
        public TextBox txtElectricityValue;
        public Label lblResult;
    }
}
