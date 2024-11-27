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
            SuspendLayout();
            // 
            // lblEnergy
            // 
            lblEnergy.AutoSize = true;
            lblEnergy.Location = new Point(514, 237);
            lblEnergy.Margin = new Padding(4, 0, 4, 0);
            lblEnergy.Name = "lblEnergy";
            lblEnergy.Size = new Size(183, 25);
            lblEnergy.TabIndex = 0;
            lblEnergy.Text = "Energy Consumption:";
            // 
            // lblTransport
            // 
            lblTransport.AutoSize = true;
            lblTransport.Location = new Point(520, 290);
            lblTransport.Margin = new Padding(4, 0, 4, 0);
            lblTransport.Name = "lblTransport";
            lblTransport.Size = new Size(178, 25);
            lblTransport.TabIndex = 1;
            lblTransport.Text = "Transportation Habit:";
            // 
            // lblMetric
            // 
            lblMetric.AutoSize = true;
            lblMetric.Location = new Point(530, 350);
            lblMetric.Margin = new Padding(4, 0, 4, 0);
            lblMetric.Name = "lblMetric";
            lblMetric.Size = new Size(165, 25);
            lblMetric.TabIndex = 2;
            lblMetric.Text = "Production Metrics:";
            // 
            // tbEnergy
            // 
            tbEnergy.Location = new Point(697, 232);
            tbEnergy.Margin = new Padding(4, 5, 4, 5);
            tbEnergy.Name = "tbEnergy";
            tbEnergy.Size = new Size(343, 31);
            tbEnergy.TabIndex = 3;
            // 
            // tbTransport
            // 
            tbTransport.Location = new Point(697, 285);
            tbTransport.Margin = new Padding(4, 5, 4, 5);
            tbTransport.Name = "tbTransport";
            tbTransport.Size = new Size(343, 31);
            tbTransport.TabIndex = 4;
            // 
            // tbMetric
            // 
            tbMetric.Location = new Point(697, 345);
            tbMetric.Margin = new Padding(4, 5, 4, 5);
            tbMetric.Name = "tbMetric";
            tbMetric.Size = new Size(343, 31);
            tbMetric.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(744, 420);
            btnCalculate.Margin = new Padding(4, 5, 4, 5);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(107, 38);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // CalculateEnergy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnCalculate);
            Controls.Add(tbMetric);
            Controls.Add(tbTransport);
            Controls.Add(tbEnergy);
            Controls.Add(lblMetric);
            Controls.Add(lblTransport);
            Controls.Add(lblEnergy);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CalculateEnergy";
            Text = "Form1";
            Load += CalculateEnergy_Load;
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
    }
}
