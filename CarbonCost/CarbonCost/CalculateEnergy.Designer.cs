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
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label5 = new Label();
            tabControl = new TabControl();
            Shipping = new TabPage();
            pictureBox5 = new PictureBox();
            label12 = new Label();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            cbTransport = new ComboBox();
            cbDistanceUnit = new ComboBox();
            label14 = new Label();
            label15 = new Label();
            txtDistanceValue = new TextBox();
            cbWeightUnit = new ComboBox();
            label16 = new Label();
            label17 = new Label();
            txtWeightValue = new TextBox();
            label1 = new Label();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            FuelCombustion = new TabPage();
            label18 = new Label();
            label19 = new Label();
            cbFuelUnit = new ComboBox();
            label20 = new Label();
            cbSource = new ComboBox();
            label21 = new Label();
            txtValueFuel = new TextBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            Electricity = new TabPage();
            cmbElectricityUnit = new ComboBox();
            txtElectricityValue = new TextBox();
            cmbState = new ComboBox();
            cmbCountry = new ComboBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            pictureBox3 = new PictureBox();
            btnCalculate = new Button();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            button1 = new Button();
            label27 = new Label();
            label28 = new Label();
            pictureBox8 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl.SuspendLayout();
            Shipping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            FuelCombustion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            Electricity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(573, 427);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(73, 375);
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
            label5.Location = new Point(119, 508);
            label5.Name = "label5";
            label5.Size = new Size(152, 28);
            label5.TabIndex = 18;
            label5.Text = "Shipping Habits";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(Shipping);
            tabControl.Controls.Add(FuelCombustion);
            tabControl.Controls.Add(Electricity);
            tabControl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl.Location = new Point(575, 1);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(582, 749);
            tabControl.TabIndex = 21;
            // 
            // Shipping
            // 
            Shipping.BackColor = Color.DarkGreen;
            Shipping.Controls.Add(pictureBox5);
            Shipping.Controls.Add(label12);
            Shipping.Controls.Add(label10);
            Shipping.Controls.Add(label11);
            Shipping.Controls.Add(label13);
            Shipping.Controls.Add(cbTransport);
            Shipping.Controls.Add(cbDistanceUnit);
            Shipping.Controls.Add(label14);
            Shipping.Controls.Add(label15);
            Shipping.Controls.Add(txtDistanceValue);
            Shipping.Controls.Add(cbWeightUnit);
            Shipping.Controls.Add(label16);
            Shipping.Controls.Add(label17);
            Shipping.Controls.Add(txtWeightValue);
            Shipping.Controls.Add(label1);
            Shipping.Controls.Add(label4);
            Shipping.Controls.Add(pictureBox4);
            Shipping.Location = new Point(4, 34);
            Shipping.Name = "Shipping";
            Shipping.Padding = new Padding(3);
            Shipping.Size = new Size(574, 711);
            Shipping.TabIndex = 1;
            Shipping.Text = "Shipping Habits";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(221, 31);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(151, 110);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 30;
            pictureBox5.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Ivory;
            label12.Font = new Font("Georgia", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(159, 166);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(281, 38);
            label12.TabIndex = 45;
            label12.Text = "Shipping Habits";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.YellowGreen;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(241, 503);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(112, 32);
            label10.TabIndex = 44;
            label10.Text = "Distance";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.YellowGreen;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(247, 319);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(95, 32);
            label11.TabIndex = 41;
            label11.Text = "Weight";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Ivory;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(26, 239);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(172, 25);
            label13.TabIndex = 38;
            label13.Text = "Transport Method:";
            // 
            // cbTransport
            // 
            cbTransport.BackColor = Color.Honeydew;
            cbTransport.FormattingEnabled = true;
            cbTransport.Location = new Point(221, 236);
            cbTransport.Name = "cbTransport";
            cbTransport.Size = new Size(319, 33);
            cbTransport.TabIndex = 39;
            cbTransport.SelectedIndexChanged += cbTransport_SelectedIndexChanged;
            // 
            // cbDistanceUnit
            // 
            cbDistanceUnit.BackColor = Color.Honeydew;
            cbDistanceUnit.FormattingEnabled = true;
            cbDistanceUnit.Location = new Point(196, 587);
            cbDistanceUnit.Name = "cbDistanceUnit";
            cbDistanceUnit.Size = new Size(319, 33);
            cbDistanceUnit.TabIndex = 37;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Ivory;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label14.Location = new Point(113, 595);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(53, 25);
            label14.TabIndex = 36;
            label14.Text = "Unit:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Ivory;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label15.Location = new Point(102, 549);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(64, 25);
            label15.TabIndex = 35;
            label15.Text = "Value:";
            // 
            // txtDistanceValue
            // 
            txtDistanceValue.BackColor = Color.Honeydew;
            txtDistanceValue.Location = new Point(196, 545);
            txtDistanceValue.Name = "txtDistanceValue";
            txtDistanceValue.Size = new Size(319, 31);
            txtDistanceValue.TabIndex = 34;
            // 
            // cbWeightUnit
            // 
            cbWeightUnit.BackColor = Color.Honeydew;
            cbWeightUnit.FormattingEnabled = true;
            cbWeightUnit.Location = new Point(196, 405);
            cbWeightUnit.Name = "cbWeightUnit";
            cbWeightUnit.Size = new Size(319, 33);
            cbWeightUnit.TabIndex = 33;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Ivory;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label16.Location = new Point(113, 405);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(53, 25);
            label16.TabIndex = 32;
            label16.Text = "Unit:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Ivory;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label17.Location = new Point(102, 365);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(64, 25);
            label17.TabIndex = 31;
            label17.Text = "Value:";
            // 
            // txtWeightValue
            // 
            txtWeightValue.BackColor = Color.Honeydew;
            txtWeightValue.Location = new Point(196, 362);
            txtWeightValue.Name = "txtWeightValue";
            txtWeightValue.Size = new Size(319, 31);
            txtWeightValue.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.YellowGreen;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(48, 310);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(492, 140);
            label1.TabIndex = 22;
            label1.Text = resources.GetString("label1.Text");
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.YellowGreen;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(48, 495);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(492, 140);
            label4.TabIndex = 46;
            label4.Text = resources.GetString("label4.Text");
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(26, 177);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(551, 538);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 47;
            pictureBox4.TabStop = false;
            // 
            // FuelCombustion
            // 
            FuelCombustion.BackColor = Color.DarkKhaki;
            FuelCombustion.Controls.Add(label18);
            FuelCombustion.Controls.Add(label19);
            FuelCombustion.Controls.Add(cbFuelUnit);
            FuelCombustion.Controls.Add(label20);
            FuelCombustion.Controls.Add(cbSource);
            FuelCombustion.Controls.Add(label21);
            FuelCombustion.Controls.Add(txtValueFuel);
            FuelCombustion.Controls.Add(pictureBox6);
            FuelCombustion.Controls.Add(pictureBox7);
            FuelCombustion.Location = new Point(4, 34);
            FuelCombustion.Name = "FuelCombustion";
            FuelCombustion.Padding = new Padding(3);
            FuelCombustion.Size = new Size(574, 711);
            FuelCombustion.TabIndex = 2;
            FuelCombustion.Text = "Fuel Combustion";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Ivory;
            label18.Font = new Font("Georgia", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(162, 227);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(298, 38);
            label18.TabIndex = 46;
            label18.Text = "Fuel Combustion";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label19.Location = new Point(132, 410);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(61, 25);
            label19.TabIndex = 44;
            label19.Text = "Units:";
            // 
            // cbFuelUnit
            // 
            cbFuelUnit.BackColor = Color.Honeydew;
            cbFuelUnit.FormattingEnabled = true;
            cbFuelUnit.Location = new Point(200, 406);
            cbFuelUnit.Name = "cbFuelUnit";
            cbFuelUnit.Size = new Size(319, 33);
            cbFuelUnit.TabIndex = 45;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label20.Location = new Point(72, 335);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(121, 25);
            label20.TabIndex = 42;
            label20.Text = "Source Type:";
            // 
            // cbSource
            // 
            cbSource.BackColor = Color.Honeydew;
            cbSource.FormattingEnabled = true;
            cbSource.Location = new Point(200, 332);
            cbSource.Name = "cbSource";
            cbSource.Size = new Size(319, 33);
            cbSource.TabIndex = 43;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label21.Location = new Point(129, 486);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(64, 25);
            label21.TabIndex = 41;
            label21.Text = "Value:";
            // 
            // txtValueFuel
            // 
            txtValueFuel.BackColor = Color.Honeydew;
            txtValueFuel.Location = new Point(200, 483);
            txtValueFuel.Name = "txtValueFuel";
            txtValueFuel.Size = new Size(319, 31);
            txtValueFuel.TabIndex = 40;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(119, 458);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(377, 245);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 47;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(-18, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(656, 169);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 30;
            pictureBox7.TabStop = false;
            // 
            // Electricity
            // 
            Electricity.BackColor = Color.PaleGoldenrod;
            Electricity.Controls.Add(cmbElectricityUnit);
            Electricity.Controls.Add(txtElectricityValue);
            Electricity.Controls.Add(cmbState);
            Electricity.Controls.Add(cmbCountry);
            Electricity.Controls.Add(pictureBox2);
            Electricity.Controls.Add(label2);
            Electricity.Controls.Add(label6);
            Electricity.Controls.Add(label7);
            Electricity.Controls.Add(label8);
            Electricity.Controls.Add(label9);
            Electricity.Controls.Add(pictureBox3);
            Electricity.Location = new Point(4, 34);
            Electricity.Name = "Electricity";
            Electricity.Padding = new Padding(3);
            Electricity.Size = new Size(574, 711);
            Electricity.TabIndex = 0;
            Electricity.Text = "Electricity Consumption";
            // 
            // cmbElectricityUnit
            // 
            cmbElectricityUnit.BackColor = Color.Honeydew;
            cmbElectricityUnit.FormattingEnabled = true;
            cmbElectricityUnit.Location = new Point(185, 296);
            cmbElectricityUnit.Name = "cmbElectricityUnit";
            cmbElectricityUnit.Size = new Size(319, 33);
            cmbElectricityUnit.TabIndex = 33;
            // 
            // txtElectricityValue
            // 
            txtElectricityValue.BackColor = Color.Honeydew;
            txtElectricityValue.Location = new Point(185, 352);
            txtElectricityValue.Name = "txtElectricityValue";
            txtElectricityValue.Size = new Size(319, 31);
            txtElectricityValue.TabIndex = 36;
            // 
            // cmbState
            // 
            cmbState.BackColor = Color.Honeydew;
            cmbState.FormattingEnabled = true;
            cmbState.Location = new Point(185, 461);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(319, 33);
            cmbState.TabIndex = 35;
            // 
            // cmbCountry
            // 
            cmbCountry.BackColor = Color.Honeydew;
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(184, 405);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(319, 33);
            cmbCountry.TabIndex = 34;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(221, 101);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightBlue;
            label2.Font = new Font("Georgia", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(86, 198);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(417, 38);
            label2.TabIndex = 30;
            label2.Text = "Electricity Consumption";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(91, 358);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(64, 25);
            label6.TabIndex = 29;
            label6.Text = "Value:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(102, 303);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 20;
            label7.Text = "Unit:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(69, 413);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(86, 25);
            label8.TabIndex = 21;
            label8.Text = "Country:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(94, 461);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(61, 25);
            label9.TabIndex = 22;
            label9.Text = "State:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-3, 441);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(574, 291);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 32;
            pictureBox3.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.YellowGreen;
            btnCalculate.Location = new Point(247, 467);
            btnCalculate.Margin = new Padding(4, 5, 4, 5);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(107, 36);
            btnCalculate.TabIndex = 29;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click_1;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.DarkGreen;
            label22.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = SystemColors.ButtonHighlight;
            label22.Location = new Point(111, 550);
            label22.Name = "label22";
            label22.Size = new Size(160, 28);
            label22.TabIndex = 30;
            label22.Text = "Fuel Combustion";
            label22.TextAlign = ContentAlignment.TopCenter;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.DarkGreen;
            label23.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.ForeColor = SystemColors.ButtonHighlight;
            label23.Location = new Point(63, 589);
            label23.Name = "label23";
            label23.Size = new Size(208, 28);
            label23.TabIndex = 31;
            label23.Text = "Electricity Combustion";
            label23.TextAlign = ContentAlignment.TopCenter;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.DarkGreen;
            label24.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.ForeColor = SystemColors.ButtonHighlight;
            label24.Location = new Point(286, 508);
            label24.Name = "label24";
            label24.Size = new Size(23, 28);
            label24.TabIndex = 32;
            label24.Text = "0";
            label24.TextAlign = ContentAlignment.TopCenter;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.DarkGreen;
            label25.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.ForeColor = SystemColors.ButtonHighlight;
            label25.Location = new Point(286, 550);
            label25.Name = "label25";
            label25.Size = new Size(23, 28);
            label25.TabIndex = 33;
            label25.Text = "0";
            label25.TextAlign = ContentAlignment.TopCenter;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.DarkGreen;
            label26.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.ForeColor = SystemColors.ButtonHighlight;
            label26.Location = new Point(286, 589);
            label26.Name = "label26";
            label26.Size = new Size(23, 28);
            label26.TabIndex = 34;
            label26.Text = "0";
            label26.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Location = new Point(220, 630);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(158, 36);
            button1.TabIndex = 35;
            button1.Text = "Calculate Total";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = Color.DarkGreen;
            label27.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.ForeColor = SystemColors.ButtonHighlight;
            label27.Location = new Point(286, 681);
            label27.Name = "label27";
            label27.Size = new Size(23, 28);
            label27.TabIndex = 37;
            label27.Text = "0";
            label27.TextAlign = ContentAlignment.TopCenter;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.BackColor = Color.DarkGreen;
            label28.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label28.ForeColor = SystemColors.ButtonHighlight;
            label28.Location = new Point(48, 681);
            label28.Name = "label28";
            label28.Size = new Size(232, 28);
            label28.TabIndex = 36;
            label28.Text = "Total Company Emissions";
            label28.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.arrow_ios_back;
            pictureBox8.Location = new Point(0, 1);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(85, 55);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 38;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // CalculateEnergy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1143, 750);
            Controls.Add(pictureBox8);
            Controls.Add(label27);
            Controls.Add(label28);
            Controls.Add(button1);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(btnCalculate);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CalculateEnergy";
            Text = "Calculate Energy";
            Load += CalculateEnergy_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl.ResumeLayout(false);
            Shipping.ResumeLayout(false);
            Shipping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            FuelCombustion.ResumeLayout(false);
            FuelCombustion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            Electricity.ResumeLayout(false);
            Electricity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label3;
        private Label label5;
        private TabControl tabControl;
        private TabPage Shipping;
        private Label label11;
        private Label label13;
        private ComboBox cbTransport;
        private ComboBox cbDistanceUnit;
        private Label label14;
        private Label label15;
        private TextBox txtDistanceValue;
        private ComboBox cbWeightUnit;
        private Label label16;
        private Label label17;
        private TextBox txtWeightValue;
        private TabPage FuelCombustion;
        private Label label19;
        private ComboBox cbFuelUnit;
        private Label label20;
        private ComboBox cbSource;
        private Label label21;
        private TextBox txtValueFuel;
        private TabPage Electricity;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label12;
        private Label label10;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label18;
        private Button btnCalculate;
        private ComboBox cmbElectricityUnit;
        private TextBox txtElectricityValue;
        private ComboBox cmbState;
        private ComboBox cmbCountry;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Button button1;
        private Label label27;
        private Label label28;
        private PictureBox pictureBox8;
    }
}
