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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateEnergy));
            lblEnergy = new Label();
            lblTransport = new Label();
            lblMetric = new Label();
            btnCalculate = new Button();
            cmbElectricityUnit = new ComboBox();
            cmbCountry = new ComboBox();
            cmbState = new ComboBox();
            lblResult = new Label();
            txtElectricityValue = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblEnergy
            // 
            lblEnergy.AutoSize = true;
            lblEnergy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEnergy.Location = new Point(661, 104);
            lblEnergy.Margin = new Padding(4, 0, 4, 0);
            lblEnergy.Name = "lblEnergy";
            lblEnergy.Size = new Size(53, 25);
            lblEnergy.TabIndex = 0;
            lblEnergy.Text = "Unit:";
            // 
            // lblTransport
            // 
            lblTransport.AutoSize = true;
            lblTransport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTransport.Location = new Point(630, 254);
            lblTransport.Margin = new Padding(4, 0, 4, 0);
            lblTransport.Name = "lblTransport";
            lblTransport.Size = new Size(86, 25);
            lblTransport.TabIndex = 1;
            lblTransport.Text = "Country:";
            // 
            // lblMetric
            // 
            lblMetric.AutoSize = true;
            lblMetric.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMetric.Location = new Point(654, 334);
            lblMetric.Margin = new Padding(4, 0, 4, 0);
            lblMetric.Name = "lblMetric";
            lblMetric.Size = new Size(61, 25);
            lblMetric.TabIndex = 2;
            lblMetric.Text = "State:";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.YellowGreen;
            btnCalculate.Location = new Point(831, 399);
            btnCalculate.Margin = new Padding(4, 5, 4, 5);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(107, 36);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // cmbElectricityUnit
            // 
            cmbElectricityUnit.BackColor = Color.Honeydew;
            cmbElectricityUnit.FormattingEnabled = true;
            cmbElectricityUnit.Location = new Point(777, 101);
            cmbElectricityUnit.Name = "cmbElectricityUnit";
            cmbElectricityUnit.Size = new Size(319, 33);
            cmbElectricityUnit.TabIndex = 7;
            // 
            // cmbCountry
            // 
            cmbCountry.BackColor = Color.Honeydew;
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(777, 251);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(319, 33);
            cmbCountry.TabIndex = 8;
            // 
            // cmbState
            // 
            cmbState.BackColor = Color.Honeydew;
            cmbState.FormattingEnabled = true;
            cmbState.Location = new Point(777, 331);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(319, 33);
            cmbState.TabIndex = 9;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(759, 471);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(235, 25);
            lblResult.TabIndex = 10;
            lblResult.Text = "Carbon Emission Estimate:";
            // 
            // txtElectricityValue
            // 
            txtElectricityValue.BackColor = Color.Honeydew;
            txtElectricityValue.Location = new Point(777, 178);
            txtElectricityValue.Name = "txtElectricityValue";
            txtElectricityValue.Size = new Size(319, 31);
            txtElectricityValue.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(651, 178);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 12;
            label1.Text = "Value:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(573, 427);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGreen;
            label2.Location = new Point(574, -2);
            label2.Name = "label2";
            label2.Size = new Size(902, 2175);
            label2.TabIndex = 14;
            label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DarkGreen;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(574, 273);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(629, 515);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(84, 438);
            label3.Name = "label3";
            label3.Size = new Size(428, 90);
            label3.TabIndex = 16;
            label3.Text = "Calculate your most recent \r\nCarbon Emission Now!";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkGreen;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(128, 572);
            label5.Name = "label5";
            label5.Size = new Size(337, 84);
            label5.TabIndex = 18;
            label5.Text = "Calculating through 2 considerations:\r\n1.) Electricity Consumption\r\n2.) Travel Habits";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(793, 50);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(214, 25);
            label4.TabIndex = 19;
            label4.Text = "Electricity Consumption";
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Location = new Point(831, 643);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 36);
            button1.TabIndex = 20;
            button1.Text = "Next Page";
            button1.UseVisualStyleBackColor = false;
            // 
            // CalculateEnergy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1143, 750);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtElectricityValue);
            Controls.Add(lblResult);
            Controls.Add(cmbState);
            Controls.Add(cmbCountry);
            Controls.Add(cmbElectricityUnit);
            Controls.Add(btnCalculate);
            Controls.Add(lblMetric);
            Controls.Add(lblTransport);
            Controls.Add(lblEnergy);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CalculateEnergy";
            Text = "Calculate Energy";
            Load += CalculateEnergy_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEnergy;
        private Label lblTransport;
        private Label lblMetric;
        private Button btnCalculate;
        private ComboBox cmbElectricityUnit;
        private ComboBox cmbCountry;
        private ComboBox cmbState;
        private Label lblResult;
        private TextBox txtElectricityValue;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Button button1;
    }
}
