namespace ASM2
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtCustomerName = new TextBox();
            txtWaterMoney = new TextBox();
            txtConsumption = new TextBox();
            txtThisMonthWaterMeter = new TextBox();
            txtLastMonthWaterMeter = new TextBox();
            btnPay = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 65);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 167);
            label2.Name = "label2";
            label2.Size = new Size(180, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Month's Water Meter:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(440, 167);
            label3.Name = "label3";
            label3.Size = new Size(180, 20);
            label3.TabIndex = 2;
            label3.Text = "This Month's Water Meter:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(198, 255);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 3;
            label4.Text = "Consumption:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(455, 255);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 4;
            label5.Text = "Water Money:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(308, 88);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(190, 27);
            txtCustomerName.TabIndex = 7;
            // 
            // txtWaterMoney
            // 
            txtWaterMoney.Location = new Point(440, 278);
            txtWaterMoney.Name = "txtWaterMoney";
            txtWaterMoney.Size = new Size(180, 27);
            txtWaterMoney.TabIndex = 9;
            // 
            // txtConsumption
            // 
            txtConsumption.Location = new Point(198, 278);
            txtConsumption.Name = "txtConsumption";
            txtConsumption.Size = new Size(180, 27);
            txtConsumption.TabIndex = 10;
            // 
            // txtThisMonthWaterMeter
            // 
            txtThisMonthWaterMeter.Location = new Point(440, 190);
            txtThisMonthWaterMeter.Name = "txtThisMonthWaterMeter";
            txtThisMonthWaterMeter.Size = new Size(180, 27);
            txtThisMonthWaterMeter.TabIndex = 11;
            // 
            // txtLastMonthWaterMeter
            // 
            txtLastMonthWaterMeter.Location = new Point(198, 189);
            txtLastMonthWaterMeter.Name = "txtLastMonthWaterMeter";
            txtLastMonthWaterMeter.Size = new Size(180, 27);
            txtLastMonthWaterMeter.TabIndex = 12;
            // 
            // btnPay
            // 
            btnPay.Font = new Font("Gill Sans Ultra Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPay.Location = new Point(341, 342);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(129, 69);
            btnPay.TabIndex = 13;
            btnPay.Text = "Payment";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(308, 9);
            label7.Name = "label7";
            label7.Size = new Size(193, 37);
            label7.TabIndex = 15;
            label7.Text = "Water Bill";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(btnPay);
            Controls.Add(txtLastMonthWaterMeter);
            Controls.Add(txtThisMonthWaterMeter);
            Controls.Add(txtConsumption);
            Controls.Add(txtWaterMoney);
            Controls.Add(txtCustomerName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtCustomerName;
        private TextBox textBox2;
        private TextBox txtWaterMoney;
        private TextBox txtConsumption;
        private TextBox txtThisMonthWaterMeter;
        private TextBox txtLastMonthWaterMeter;
        private Button btnPay;
        private Label label7;
    }
}