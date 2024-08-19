using System.Runtime.Versioning;
namespace ASM2
{
    public partial class btn : Form
    {
        public const double VAT = 0.1;

        private List<Invoice> invoices; // Declare list of invoices

        public btn()

        {
            InitializeComponent();
            invoices = new List<Invoice>(); // initialize invoice list
            cboDetail.SelectedIndexChanged += new EventHandler(cboDetail_SelectedIndexChanged);
            lvWaterBill.SelectedIndexChanged += new EventHandler(lvWaterBill_SelectedIndexChanged); // Assigning events to ListView

        }

        private void customerName_TextChanged(object sender, EventArgs e)
        {

        }


        private void NumberOfPeople_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastMonthWaterMeter_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThisMonthWaterMeter_TextChanged(object sender, EventArgs e)
        {

        }

        private void Caculate_Click(object sender, EventArgs e) // Handling logic when the user presses a button

        {
            string customerName = txtCustomerName.Text.Trim();
            string customerType = cboTypeOfCustomer.Text;
            int numberOfPeople = 0;
            double lastMonthWaterMeter = 0;
            double thisMonthWaterMeter = 0;

            //
            if (customerName == "")
            {
                MessageBox.Show("Please enter customer name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (customerType == "")
            {
                MessageBox.Show("Please enter customer type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (customerType == "Household customer")
            {
                if (!int.TryParse(txtNumberOfPeople.Text, out numberOfPeople) || numberOfPeople <= 0)
                {
                    MessageBox.Show("Please enter number of people.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!double.TryParse(txtLastMonthWaterMeter.Text, out lastMonthWaterMeter) || lastMonthWaterMeter <= 0)
            {
                MessageBox.Show("Please enter last month's water meter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtThisMonthWaterMeter.Text, out thisMonthWaterMeter) || thisMonthWaterMeter <= 0)
            {
                MessageBox.Show("Please enter this month's water meter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var waterBill = Calculator(customerType, numberOfPeople, lastMonthWaterMeter, thisMonthWaterMeter); //waterBill chua thong tin tien nuoc gom( so nuoc da su dung, tien nuoc cua khach hang)
            // kieu object 

            // Show result
            ListViewItem item = new ListViewItem(customerName);
            item.SubItems.Add(lastMonthWaterMeter.ToString());
            item.SubItems.Add(thisMonthWaterMeter.ToString());
            item.SubItems.Add(waterBill.Item1.ToString());
            item.SubItems.Add(waterBill.Item2.ToString());
            lvWaterBill.Items.Add(item);

            // Store data
            Invoice invoice = new Invoice
            {
                CustomerName = customerName,
                LastMonthWaterMeter = lastMonthWaterMeter,
                ThisMonthWaterMeter = thisMonthWaterMeter,
                Consumption = waterBill.Item1,
                WaterMoney = waterBill.Item2
            };
            invoices.Add(invoice);
        }



        private (double, double) Calculator(string customerType, int numberOfMember, double lastMonthWaterMeter, double thisMonthWaterMeter)
        {
            double consumption = thisMonthWaterMeter - lastMonthWaterMeter; // Calculate water consumption 
            double waterMoney = 0;

            if (customerType == "Household customer")
            {
                double averagePerson = consumption / numberOfMember; // average water consumption per person = total water used / number of members
                if (averagePerson < 10)
                {
                    waterMoney = consumption * 5973;
                }
                else if (averagePerson >= 10 && averagePerson < 20)
                {
                    waterMoney = consumption * 7052;
                }
                else if (averagePerson >= 20 && averagePerson < 30)
                {
                    waterMoney = consumption * 8699;
                }
                else if (averagePerson >= 30)
                {
                    waterMoney = consumption * 15929;
                }
            }
            else if (customerType == "Administration agency, public services")
            {
                waterMoney = consumption * 9955;
            }
            else if (customerType == "Production units")
            {
                waterMoney = consumption * 11615;
            }
            else if (customerType == "Business services")
            {
                waterMoney = consumption * 22068;
            }

            waterMoney += (waterMoney * VAT); // Apply VAT 

            return (consumption, waterMoney);
        }
        private void cboTypeOfCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customerName = cboTypeOfCustomer.Text;
            if (customerName == "Household customer")
            {
                txtNumberOfPeople.Enabled = true;
            }
            else
            {
                txtNumberOfPeople.Enabled = false;
                txtNumberOfPeople.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboTypeOfCustomer.Items.Add("Household customer");
            cboTypeOfCustomer.Items.Add("Administration agency, public services");
            cboTypeOfCustomer.Items.Add("Production units");
            cboTypeOfCustomer.Items.Add("Business services");

            lvWaterBill.View = View.Details;
            lvWaterBill.Columns.Add("Customer Name", 200);
            lvWaterBill.Columns.Add("Last Month Water Meter", 200);
            lvWaterBill.Columns.Add("This Month Water Meter", 200);
            lvWaterBill.Columns.Add("Amount Of Consumption", 200);
            lvWaterBill.Columns.Add("Total Water Bill", 200);

            cboDetail.Items.Add("None");
            cboDetail.Items.Add("Name (A-Z)");
            cboDetail.Items.Add("The water bill (from low to high)");
            cboDetail.Items.Add("The water bill (from high to low)");
        }

        private void lvWaterBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (lvWaterBill.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = lvWaterBill.SelectedItems[0];
                    string customerName = selectedItem.SubItems[0].Text;

                    Invoice selectedInvoice = invoices.FirstOrDefault(invoice => invoice.CustomerName == customerName);
                    if (selectedInvoice != null)
                    {
                        Form2 form2 = new Form2(selectedInvoice);
                        form2.ShowDialog();
                    }
                }
            }

        }

        private void txtSeach_TextChanged(object sender, EventArgs e)
        {
            string search = txtSeach.Text.Trim();
            lvWaterBill.Items.Clear();
            bool foundResult = false;

            if (search == "")
            {
                foreach (Invoice invoice in invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.LastMonthWaterMeter.ToString());
                    item.SubItems.Add(invoice.ThisMonthWaterMeter.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.WaterMoney.ToString());
                    lvWaterBill.Items.Add(item);
                }
                foundResult = true;
            }
            else
            {
                foreach (Invoice invoice in invoices)
                {
                    if (invoice.CustomerName == search) // CustomerName = abc, search = b => true 
                    {
                        ListViewItem item = new ListViewItem(invoice.CustomerName);
                        item.SubItems.Add(invoice.LastMonthWaterMeter.ToString());
                        item.SubItems.Add(invoice.ThisMonthWaterMeter.ToString());
                        item.SubItems.Add(invoice.Consumption.ToString());
                        item.SubItems.Add(invoice.WaterMoney.ToString());
                        lvWaterBill.Items.Add(item);
                        foundResult = true;
                    }
                }
            }
            if (!foundResult)
            {
                ListViewItem item = new ListViewItem("No result found.");
                lvWaterBill.Items.Add(item);
            }
        }
        public class Invoice
        {
            public string CustomerName { get; set; }
            public double LastMonthWaterMeter { get; set; }
            public double ThisMonthWaterMeter { get; set; }
            public double Consumption { get; set; }
            public double WaterMoney { get; set; }
        }

        private void cboDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                {
                    string selectedOption = cboDetail.SelectedItem.ToString();

                    switch (selectedOption)
                    {
                        case "Name (A-Z)":
                            invoices = invoices.OrderBy(invoice => invoice.CustomerName).ToList();
                            break;

                        case "The water bill (from low to high)":
                            invoices = invoices.OrderBy(invoice => invoice.WaterMoney).ToList();
                            break;

                        case "The water bill (from high to low)":
                            invoices = invoices.OrderByDescending(invoice => invoice.WaterMoney).ToList();
                            break;
                    }

                    // update listview
                    lvWaterBill.Items.Clear();
                    foreach (Invoice invoice in invoices)
                    {
                        ListViewItem item = new ListViewItem(invoice.CustomerName);
                        item.SubItems.Add(invoice.LastMonthWaterMeter.ToString());
                        item.SubItems.Add(invoice.ThisMonthWaterMeter.ToString());
                        item.SubItems.Add(invoice.Consumption.ToString());
                        item.SubItems.Add(invoice.WaterMoney.ToString());
                        lvWaterBill.Items.Add(item);
                    }
                }
            }
        }


    }
}
