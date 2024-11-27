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
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(467, 48);
            label1.TabIndex = 7;
            label1.Text = "Company Profile and Limit";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(180, 164);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 19;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(177, 114);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 18;
            label6.Text = "label6";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(79, 108);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 32);
            label4.TabIndex = 17;
            label4.Text = "Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(79, 158);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 32);
            label5.TabIndex = 16;
            label5.Text = "Excess :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 290);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 32);
            label3.TabIndex = 23;
            label3.Text = "ID:";
            // 
            // txtCompanyId
            // 
            txtCompanyId.Location = new Point(132, 289);
            txtCompanyId.Margin = new Padding(4, 5, 4, 5);
            txtCompanyId.Name = "txtCompanyId";
            txtCompanyId.Size = new Size(418, 31);
            txtCompanyId.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 338);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 32);
            label2.TabIndex = 21;
            label2.Text = "Amount:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(132, 337);
            txtAmount.Margin = new Padding(4, 5, 4, 5);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(418, 31);
            txtAmount.TabIndex = 20;
            // 
            // btnSell
            // 
            btnSell.BackColor = Color.FromArgb(128, 255, 128);
            btnSell.Location = new Point(773, 34);
            btnSell.Margin = new Padding(4, 5, 4, 5);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(194, 38);
            btnSell.TabIndex = 26;
            btnSell.Text = "Sell";
            btnSell.UseVisualStyleBackColor = false;
            btnSell.Click += btnSell_Click;
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.IndianRed;
            btnBuy.Location = new Point(570, 34);
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
            dataGridView2.Location = new Point(570, 83);
            dataGridView2.Margin = new Padding(4, 5, 4, 5);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(400, 287);
            dataGridView2.TabIndex = 24;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // load
            // 
            load.Location = new Point(885, 378);
            load.Margin = new Padding(4, 5, 4, 5);
            load.Name = "load";
            load.Size = new Size(107, 38);
            load.TabIndex = 29;
            load.Text = "Load Data";
            load.UseVisualStyleBackColor = true;
            load.Click += load_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 466);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(967, 262);
            dataGridView1.TabIndex = 28;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboBoxCompany
            // 
            comboBoxCompany.FormattingEnabled = true;
            comboBoxCompany.Location = new Point(25, 380);
            comboBoxCompany.Margin = new Padding(4, 5, 4, 5);
            comboBoxCompany.Name = "comboBoxCompany";
            comboBoxCompany.Size = new Size(850, 33);
            comboBoxCompany.TabIndex = 27;
            comboBoxCompany.SelectedIndexChanged += comboBoxCompany_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(195, 236);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(229, 48);
            label8.TabIndex = 30;
            label8.Text = "Transactions";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(442, 164);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(59, 25);
            label9.TabIndex = 34;
            label9.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(439, 114);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(69, 25);
            label10.TabIndex = 33;
            label10.Text = "label10";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(341, 108);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(67, 32);
            label11.TabIndex = 32;
            label11.Text = "PPC :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(341, 158);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(92, 32);
            label12.TabIndex = 31;
            label12.Text = "Quota :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(311, 413);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(399, 48);
            label13.TabIndex = 35;
            label13.Text = "Historical Transactions";
            // 
            // Trading
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 748);
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
            Name = "Trading";
            Text = "Trading";
            Load += Trading_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}