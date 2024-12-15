namespace CarbonCost
{
    partial class Trading
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
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtCompanyId = new TextBox();
            label2 = new Label();
            txtAmount = new TextBox();
            btnSell = new Button();
            btnBuy = new Button();
            dataGridView2 = new DataGridView();
            load = new Button();
            dataGridView1 = new DataGridView();
            comboBoxCompany = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            pictureBox1 = new PictureBox();
            label23 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSeaGreen;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(34, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(520, 41);
            label1.TabIndex = 7;
            label1.Text = "Company Profile and Limit";
            label1.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FloralWhite;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = SystemColors.WindowText;
            label7.Location = new Point(173, 150);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 28);
            label7.TabIndex = 19;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FloralWhite;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = SystemColors.WindowText;
            label6.Location = new Point(170, 100);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(65, 28);
            label6.TabIndex = 18;
            label6.Text = "label6";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FloralWhite;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(76, 100);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 17;
            label4.Text = "Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FloralWhite;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.ForeColor = SystemColors.WindowText;
            label5.Location = new Point(72, 150);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(81, 28);
            label5.TabIndex = 16;
            label5.Text = "Excess :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSeaGreen;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(85, 275);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 32);
            label3.TabIndex = 23;
            label3.Text = "ID:";
            // 
            // txtCompanyId
            // 
            txtCompanyId.Location = new Point(140, 277);
            txtCompanyId.Margin = new Padding(4, 5, 4, 5);
            txtCompanyId.Name = "txtCompanyId";
            txtCompanyId.Size = new Size(418, 31);
            txtCompanyId.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSeaGreen;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(22, 324);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 32);
            label2.TabIndex = 21;
            label2.Text = "Amount:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(140, 325);
            txtAmount.Margin = new Padding(4, 5, 4, 5);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(418, 31);
            txtAmount.TabIndex = 20;
            // 
            // btnSell
            // 
            btnSell.BackColor = Color.FromArgb(128, 255, 128);
            btnSell.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSell.ForeColor = SystemColors.ControlText;
            btnSell.Location = new Point(794, 34);
            btnSell.Margin = new Padding(4, 5, 4, 5);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(198, 38);
            btnSell.TabIndex = 26;
            btnSell.Text = "Sell";
            btnSell.UseVisualStyleBackColor = false;
            btnSell.Click += btnSell_Click;
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.IndianRed;
            btnBuy.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnBuy.ForeColor = SystemColors.ControlText;
            btnBuy.Location = new Point(592, 34);
            btnBuy.Margin = new Padding(4, 5, 4, 5);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(194, 38);
            btnBuy.TabIndex = 25;
            btnBuy.Text = "Buy";
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += btnBuy_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(592, 83);
            dataGridView2.Margin = new Padding(4, 5, 4, 5);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(400, 273);
            dataGridView2.TabIndex = 24;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // load
            // 
            load.BackColor = Color.DarkGreen;
            load.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            load.ForeColor = SystemColors.ButtonFace;
            load.Location = new Point(887, 435);
            load.Margin = new Padding(4, 5, 4, 5);
            load.Name = "load";
            load.Size = new Size(107, 38);
            load.TabIndex = 29;
            load.Text = "Load Data";
            load.UseVisualStyleBackColor = false;
            load.Click += load_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 481);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(967, 232);
            dataGridView1.TabIndex = 28;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboBoxCompany
            // 
            comboBoxCompany.FormattingEnabled = true;
            comboBoxCompany.Location = new Point(27, 437);
            comboBoxCompany.Margin = new Padding(4, 5, 4, 5);
            comboBoxCompany.Name = "comboBoxCompany";
            comboBoxCompany.Size = new Size(850, 33);
            comboBoxCompany.TabIndex = 27;
            comboBoxCompany.SelectedIndexChanged += comboBoxCompany_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkSeaGreen;
            label8.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(173, 221);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(259, 41);
            label8.TabIndex = 30;
            label8.Text = "Transactions";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FloralWhite;
            label9.Font = new Font("Segoe UI", 10F);
            label9.ForeColor = SystemColors.WindowText;
            label9.Location = new Point(435, 150);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(65, 28);
            label9.TabIndex = 34;
            label9.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FloralWhite;
            label10.Font = new Font("Segoe UI", 10F);
            label10.ForeColor = SystemColors.WindowText;
            label10.Location = new Point(435, 100);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(76, 28);
            label10.TabIndex = 33;
            label10.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FloralWhite;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label11.ForeColor = SystemColors.WindowText;
            label11.Location = new Point(354, 100);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(59, 28);
            label11.TabIndex = 32;
            label11.Text = "PPC :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FloralWhite;
            label12.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label12.ForeColor = SystemColors.WindowText;
            label12.Location = new Point(334, 150);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(79, 28);
            label12.TabIndex = 31;
            label12.Text = "Quota :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.DarkSeaGreen;
            label13.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(333, 391);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(453, 41);
            label13.TabIndex = 35;
            label13.Text = "Historical Transactions";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Cover;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1020, 747);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.DarkSeaGreen;
            label23.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.ForeColor = SystemColors.ButtonHighlight;
            label23.Location = new Point(34, 83);
            label23.Name = "label23";
            label23.RightToLeft = RightToLeft.Yes;
            label23.Size = new Size(522, 112);
            label23.TabIndex = 50;
            label23.Text = "\r\n\r\n                                                                                                      \r\n                                                                                         ";
            label23.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(885, 391);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 51;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Trading
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 748);
            Controls.Add(button1);
            Controls.Add(label13);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(load);
            Controls.Add(dataGridView1);
            Controls.Add(comboBoxCompany);
            Controls.Add(btnSell);
            Controls.Add(btnBuy);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(txtCompanyId);
            Controls.Add(label2);
            Controls.Add(txtAmount);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label23);
            Controls.Add(pictureBox1);
            Name = "Trading";
            Text = "Trading";
            Load += Trading_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label5;
        private Label label3;
        private TextBox txtCompanyId;
        private Label label2;
        private TextBox txtAmount;
        private Button btnSell;
        private Button btnBuy;
        private DataGridView dataGridView2;
        private Button load;
        private DataGridView dataGridView1;
        private ComboBox comboBoxCompany;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private PictureBox pictureBox1;
        private Label label23;
        private Button button1;
    }
}