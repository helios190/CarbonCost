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
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(467, 48);
            label1.TabIndex = 7;
            label1.Text = "Company Profile and Limit";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(122, 145);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 19;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(249, 96);
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
            label4.Location = new Point(55, 90);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(196, 32);
            label4.TabIndex = 17;
            label4.Text = "Company Profile:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(55, 139);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 16;
            label5.Text = "Limit:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 327);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 32);
            label3.TabIndex = 23;
            label3.Text = "ID:";
            // 
            // txtCompanyId
            // 
            txtCompanyId.Location = new Point(173, 327);
            txtCompanyId.Margin = new Padding(4, 5, 4, 5);
            txtCompanyId.Name = "txtCompanyId";
            txtCompanyId.Size = new Size(377, 31);
            txtCompanyId.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 375);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 32);
            label2.TabIndex = 21;
            label2.Text = "Amount:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(173, 375);
            txtAmount.Margin = new Padding(4, 5, 4, 5);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(377, 31);
            txtAmount.TabIndex = 20;
            // 
            // btnSell
            // 
            btnSell.BackColor = Color.FromArgb(128, 255, 128);
            btnSell.Location = new Point(773, 72);
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
            btnBuy.Location = new Point(570, 72);
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
            dataGridView2.Location = new Point(570, 121);
            dataGridView2.Margin = new Padding(4, 5, 4, 5);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(400, 287);
            dataGridView2.TabIndex = 24;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // load
            // 
            load.Location = new Point(885, 416);
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
            comboBoxCompany.Location = new Point(25, 418);
            comboBoxCompany.Margin = new Padding(4, 5, 4, 5);
            comboBoxCompany.Name = "comboBoxCompany";
            comboBoxCompany.Size = new Size(850, 33);
            comboBoxCompany.TabIndex = 27;
            comboBoxCompany.SelectedIndexChanged += comboBoxCompany_SelectedIndexChanged;
            // 
            // Trading
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 748);
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
    }
}