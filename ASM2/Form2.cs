using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ASM2.btn;

namespace ASM2
{
    public partial class Form2 : Form

    {
        public Form2( Invoice invoice)
        {
            InitializeComponent();
            txtCustomerName.Text = invoice.CustomerName;
            txtLastMonthWaterMeter.Text = invoice.LastMonthWaterMeter.ToString();
            txtThisMonthWaterMeter.Text = invoice.ThisMonthWaterMeter.ToString();
            txtConsumption.Text = invoice.Consumption.ToString();
            txtWaterMoney.Text = invoice.WaterMoney.ToString();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment Successful!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
