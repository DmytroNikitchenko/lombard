using lombard.Models;

namespace lombard.View
{
    public partial class FullInfo : Form //Форма з повною інформацією
    {
        public FullInfo(PawnshopDatabase database, DataGridViewRow row)
        {
            InitializeComponent();

            int itemId = Convert.ToInt32(row.Cells["Id"].Value);
            Item foundItem = database.GetItemById(itemId);
            Client foundClient = database.GetClientById(foundItem.ClientId);

            textItemId.Text = foundItem.Id.ToString();
            textItemName.Text = foundItem.Name;
            textEstimatedValue.Text = foundItem.EstimatedValue.ToString();
            textLoanAmount.Text = foundItem.LoanAmount.ToString();
            textDepositDate.Text = foundItem.DepositDate.ToShortDateString();
            textStorageDays.Text = foundItem.StoragePeriodDays.ToString();
            textItemStatus.Text = foundItem.Status.ToString();
            textBoxStatusToSaleOrReturn.Text = foundItem.StatusToSaleOrReturn.ToString();
            textItemCategory.Text = foundItem.Category;

            if (foundItem.Status == ItemStatus.Зберігається)
            {
                textSaleReturnDate.Visible = false;
                labelSaleReturnDate.Visible = false;
                labelSaleReturnPrice.Visible = false;
                textSaleReturnPrice.Visible = false;

                labelBuyerName.Visible = false;
                labelBuyerNumber.Visible = false;
                textBoxBuyerName.Visible = false;
                textBoxBuyerNumber.Visible = false;

            }
            else
            {
                textSaleReturnDate.Text = foundItem.SaleReturnDate == DateTime.MinValue
                    ? "Зберігається"
                    : foundItem.SaleReturnDate.ToShortDateString();
                textSaleReturnDate.Visible = true;
                labelSaleReturnDate.Visible = true;

                textSaleReturnPrice.Text = foundItem.Status == ItemStatus.Повернено
                    ? foundItem.RedemptionPrice.ToString()
                    : foundItem.EstimatedValue.ToString();
                labelSaleReturnPrice.Visible = true;
                textSaleReturnPrice.Visible = true;

                if (foundItem.Status == ItemStatus.Продано)
                {
                    labelBuyerName.Visible = true;
                    labelBuyerNumber.Visible = true;
                    textBoxBuyerName.Visible = true;
                    textBoxBuyerNumber.Visible = true;

                    textBoxBuyerName.Text = foundItem.Buyer.FullName;
                    textBoxBuyerNumber.Text = foundItem.Buyer.PhoneNumber;
                }
                else
                {
                    labelBuyerName.Visible = false;
                    labelBuyerNumber.Visible = false;
                    textBoxBuyerName.Visible = false;
                    textBoxBuyerNumber.Visible = false;
                }
            }


            textClientId.Text = foundClient.Id.ToString();
            textClientName.Text = foundClient.FullName;
            textClientPhone.Text = foundClient.PhoneNumber;
        }
    }
}