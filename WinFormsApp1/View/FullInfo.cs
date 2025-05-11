using lombard.Models;

namespace lombard.View
{
    public partial class FullInfo : Form //Форма з повною інформацією
    {
        public FullInfo(PawnshopDatabase database, DataGridViewRow row)
        {
            InitializeComponent();
            Item foundItem = database.GetItemById(Convert.ToInt32(row.Cells["Id"].Value));
            Client foundClient = database.GetClientById(Convert.ToInt32(row.Cells["ClientId"].Value));


            textItemId.Text = row.Cells["Id"].Value.ToString();
            textItemName.Text = row.Cells["Name"].Value.ToString();
            textEstimatedValue.Text = row.Cells["EstimatedValue"].Value.ToString();
            textLoanAmount.Text = row.Cells["LoanAmount"].Value.ToString();
            textDepositDate.Text = row.Cells["DepositDate"].Value.ToString();
            textStorageDays.Text = row.Cells["StoragePeriodDays"].Value.ToString();
            textItemStatus.Text = row.Cells["Status"].Value.ToString();
            textItemCategory.Text = row.Cells["Category"].Value.ToString();

            if (row.Cells["Status"].Value.ToString() == "Зберігається")
            {
                textSaleReturnDate.Visible = false;
                labelSaleReturnDate.Visible = false;
                labelSaleReturnPrice.Visible = false;
                textSaleReturnPrice.Visible = false;
            }
            else
            {
                textSaleReturnDate.Text = row.Cells["SaleReturnDate"].Value.ToString() == "01.01.0001 0:00:00" ? "Зберігається" : row.Cells["SaleReturnDate"].Value.ToString();
                textSaleReturnDate.Visible = true;
                labelSaleReturnDate.Visible = true;

                textSaleReturnPrice.Text = row.Cells["Status"].Value.ToString() == "Повернено" ? row.Cells["RedemptionPrice"].Value.ToString() : row.Cells["EstimatedValue"].Value.ToString();
                labelSaleReturnPrice.Visible = true;
                textSaleReturnPrice.Visible = true;
            }
            textClientId.Text = row.Cells["ClientId"].Value.ToString();
            textClientName.Text = foundClient.FullName.ToString();
            textClientPhone.Text = foundClient.PhoneNumber.ToString();
        }
    }
}
