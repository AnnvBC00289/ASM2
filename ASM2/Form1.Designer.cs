namespace ASM2
{
    partial class btn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btn));
            groupBox1 = new GroupBox();
            cboTypeOfCustomer = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnClear = new Button();
            btnCalculator = new Button();
            txtThisMonthWaterMeter = new TextBox();
            txtLastMonthWaterMeter = new TextBox();
            txtNumberOfPeople = new TextBox();
            txtCustomerName = new TextBox();
            txtSeach = new TextBox();
            label6 = new Label();
            lvWaterBill = new ListView();
            cboDetail = new ComboBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Silver;
            groupBox1.Controls.Add(cboTypeOfCustomer);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnCalculator);
            groupBox1.Controls.Add(txtThisMonthWaterMeter);
            groupBox1.Controls.Add(txtLastMonthWaterMeter);
            groupBox1.Controls.Add(txtNumberOfPeople);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 479);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculator Form";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cboTypeOfCustomer
            // 
            cboTypeOfCustomer.Font = new Font("Arial Rounded MT Bold", 9F);
            cboTypeOfCustomer.FormattingEnabled = true;
            cboTypeOfCustomer.Location = new Point(29, 122);
            cboTypeOfCustomer.Name = "cboTypeOfCustomer";
            cboTypeOfCustomer.Size = new Size(244, 25);
            cboTypeOfCustomer.TabIndex = 12;
            cboTypeOfCustomer.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 314);
            label5.Name = "label5";
            label5.Size = new Size(179, 18);
            label5.TabIndex = 11;
            label5.Text = "This month's water meter:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 238);
            label4.Name = "label4";
            label4.Size = new Size(179, 18);
            label4.TabIndex = 10;
            label4.Text = "Last month's water meter:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 167);
            label3.Name = "label3";
            label3.Size = new Size(130, 18);
            label3.TabIndex = 9;
            label3.Text = "Number of people:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 101);
            label2.Name = "label2";
            label2.Size = new Size(128, 18);
            label2.TabIndex = 8;
            label2.Text = "Type of customer:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 35);
            label1.Name = "label1";
            label1.Size = new Size(122, 18);
            label1.TabIndex = 7;
            label1.Text = "Customer Name:";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(29, 393);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += Clear_Click;
            // 
            // btnCalculator
            // 
            btnCalculator.Location = new Point(151, 393);
            btnCalculator.Name = "btnCalculator";
            btnCalculator.Size = new Size(144, 29);
            btnCalculator.TabIndex = 5;
            btnCalculator.Text = "Calculator";
            btnCalculator.UseVisualStyleBackColor = true;
            btnCalculator.Click += Caculate_Click;
            // 
            // txtThisMonthWaterMeter
            // 
            txtThisMonthWaterMeter.Font = new Font("Arial Rounded MT Bold", 9F);
            txtThisMonthWaterMeter.Location = new Point(29, 336);
            txtThisMonthWaterMeter.Name = "txtThisMonthWaterMeter";
            txtThisMonthWaterMeter.PlaceholderText = "Enter this month's water meter";
            txtThisMonthWaterMeter.Size = new Size(244, 25);
            txtThisMonthWaterMeter.TabIndex = 4;
            txtThisMonthWaterMeter.TextChanged += ThisMonthWaterMeter_TextChanged;
            // 
            // txtLastMonthWaterMeter
            // 
            txtLastMonthWaterMeter.Font = new Font("Arial Rounded MT Bold", 9F);
            txtLastMonthWaterMeter.Location = new Point(29, 260);
            txtLastMonthWaterMeter.Name = "txtLastMonthWaterMeter";
            txtLastMonthWaterMeter.PlaceholderText = "Enter last month's water meter";
            txtLastMonthWaterMeter.Size = new Size(244, 25);
            txtLastMonthWaterMeter.TabIndex = 3;
            txtLastMonthWaterMeter.TextChanged += LastMonthWaterMeter_TextChanged;
            // 
            // txtNumberOfPeople
            // 
            txtNumberOfPeople.Enabled = false;
            txtNumberOfPeople.Font = new Font("Arial Rounded MT Bold", 9F);
            txtNumberOfPeople.Location = new Point(29, 188);
            txtNumberOfPeople.Name = "txtNumberOfPeople";
            txtNumberOfPeople.PlaceholderText = "Enter number of member";
            txtNumberOfPeople.Size = new Size(244, 25);
            txtNumberOfPeople.TabIndex = 2;
            txtNumberOfPeople.TextChanged += NumberOfPeople_TextChanged;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Arial Rounded MT Bold", 9F);
            txtCustomerName.Location = new Point(29, 56);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Enter customer name";
            txtCustomerName.Size = new Size(244, 25);
            txtCustomerName.TabIndex = 0;
            txtCustomerName.TextChanged += customerName_TextChanged;
            // 
            // txtSeach
            // 
            txtSeach.BackColor = Color.Silver;
            txtSeach.Location = new Point(455, 7);
            txtSeach.Name = "txtSeach";
            txtSeach.Size = new Size(268, 27);
            txtSeach.TabIndex = 1;
            txtSeach.TextChanged += txtSeach_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Broadway", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.ImageAlign = ContentAlignment.BottomCenter;
            label6.Location = new Point(370, 9);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 2;
            label6.Text = "Search:";
            // 
            // lvWaterBill
            // 
            lvWaterBill.BackColor = Color.Silver;
            lvWaterBill.Location = new Point(373, 58);
            lvWaterBill.Name = "lvWaterBill";
            lvWaterBill.Size = new Size(908, 423);
            lvWaterBill.TabIndex = 3;
            lvWaterBill.UseCompatibleStateImageBehavior = false;
            lvWaterBill.SelectedIndexChanged += lvWaterBill_SelectedIndexChanged;
            // 
            // cboDetail
            // 
            cboDetail.BackColor = Color.Silver;
            cboDetail.ForeColor = Color.Black;
            cboDetail.FormattingEnabled = true;
            cboDetail.Location = new Point(977, 6);
            cboDetail.Name = "cboDetail";
            cboDetail.Size = new Size(227, 28);
            cboDetail.TabIndex = 4;
            cboDetail.SelectedIndexChanged += cboDetail_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Broadway", 10.8F);
            label7.Location = new Point(900, 11);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 5;
            label7.Text = "Detail:";
            // 
            // btn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 533);
            Controls.Add(label7);
            Controls.Add(cboDetail);
            Controls.Add(lvWaterBill);
            Controls.Add(label6);
            Controls.Add(txtSeach);
            Controls.Add(groupBox1);
            Name = "btn";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnClear;
        private Button btnCalculator;
        private TextBox txtThisMonthWaterMeter;
        private TextBox txtLastMonthWaterMeter;
        private TextBox txtNumberOfPeople;
        private TextBox typeOfCustomer;
        private TextBox txtCustomerName;
        private TextBox txtSeach;
        private Label label6;
        private ComboBox cboTypeOfCustomer;
        private ListView lvWaterBill;
        private ComboBox cboDetail;
        private Label label7;
    }
}
