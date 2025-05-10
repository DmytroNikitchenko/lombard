using lombard.Models;

namespace lombard.View
{
    public partial class FullInfo : Form //Форма з повною інформацією
    {
        public FullInfo(PawnshopDatabase database, DataGridViewRow row)
        {
            InitializeComponent();
            int ClientId = Convert.ToInt32(row.Cells["ClientId"].Value);
            Client foundClient = database.GetClientById(ClientId);


            textBox1.Text = row.Cells["Id"].Value.ToString();
            textBox2.Text = row.Cells["Name"].Value.ToString();
            textBox3.Text = row.Cells["EstimatedValue"].Value.ToString();
            textBox4.Text = row.Cells["LoanAmount"].Value.ToString();
            textBox5.Text = row.Cells["DepositDate"].Value.ToString();
            textBox6.Text = row.Cells["StoragePeriodDays"].Value.ToString();
            textBox7.Text = row.Cells["Status"].Value.ToString();
            textBox12.Text = row.Cells["Category"].Value.ToString();

            if (row.Cells["Status"].Value.ToString() == "Зберігається")
            {
                textBox8.Visible = false;
                label21.Visible = false;
            }
            else
            {
                textBox8.Text = row.Cells["SaleReturnDate"].Value.ToString() == "01.01.0001 0:00:00" ? "Зберігається" : row.Cells["SaleReturnDate"].Value.ToString();
                textBox8.Visible = true;
                label21.Visible = true;
            }
            textBox9.Text = row.Cells["ClientId"].Value.ToString();
            textBox10.Text = foundClient.FullName.ToString();
            textBox11.Text = foundClient.PhoneNumber.ToString();
        }
    }
}
