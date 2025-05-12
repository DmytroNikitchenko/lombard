using lombard.Models;
using System.Drawing.Printing;


namespace lombard.View
{
    public partial class MainForm : Form //Головне вікно
    {
        private PawnshopDatabase database;
        public MainForm()
        {
            InitializeComponent();
            database = DatabaseManager.LoadData();
            ArrayViev.DataSource = database.Items;
            database.Items.Sort((x, y) => x.Id.CompareTo(y.Id));

            FormatColumnsNames(ArrayViev);
        }

        public static void FormatColumnsNames(DataGridView dataGridView)
        {
            dataGridView.Columns["Id"].HeaderText = "ID";
            dataGridView.Columns["Name"].HeaderText = "Назва";
            dataGridView.Columns["EstimatedValue"].HeaderText = "Оцінка (грн.)";
            dataGridView.Columns["LoanAmount"].HeaderText = "Сума кредиту (грн.)";
            dataGridView.Columns["DepositDate"].HeaderText = "Дата внеску";
            dataGridView.Columns["StoragePeriodDays"].HeaderText = "Строк зберігання (дн.)";
            dataGridView.Columns["Status"].HeaderText = "Статус на складі";
            dataGridView.Columns["ClientId"].HeaderText = "ID клієнта";
            dataGridView.Columns["SaleReturnDate"].HeaderText = "Дата продажу/повернення";
            dataGridView.Columns["Category"].HeaderText = "Категорія";
            dataGridView.Columns["RedemptionPrice"].HeaderText = "Викупна ціна";
            dataGridView.Columns["StatusToSaleOrReturn"].HeaderText = "Статус для продажу";
        }
        public void RefreshDataGrid()
        {
            database = DatabaseManager.LoadData();
            ArrayViev.DataSource = database.Items;
        }
        public void RefreshDataCustom(List<Item> custom)
        {
            ArrayViev.DataSource = custom;
        }
        private void ArrayViev_SelectionChanged(object sender, EventArgs e)
        {
            if (ArrayViev.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ArrayViev.SelectedRows[0];
                var statusCell = selectedRow.Cells["Status"].Value;

                if (statusCell != null)
                {
                    string status = statusCell.ToString();

                    bool isActive = status != ItemStatus.Повернено.ToString() && status != ItemStatus.Продано.ToString();

                    if (isActive)
                    {
                        int storageDays = Convert.ToInt32(selectedRow.Cells["StoragePeriodDays"].Value);
                        DateTime depositDate = Convert.ToDateTime(selectedRow.Cells["DepositDate"].Value);
                        DateTime storageEndDate = depositDate.AddDays(storageDays);


                        buttonSell.Enabled = storageEndDate <= DateTime.Now;

                        buttonSell.Enabled = storageEndDate <= DateTime.Now;

                        buttonRefound.Enabled = storageEndDate > DateTime.Now;
                    }
                    else
                    {
                        buttonSell.Enabled = false;
                        buttonRefound.Enabled = false;
                    }
                }
            }
            else
            {
                buttonRefound.Enabled = false;
                buttonSell.Enabled = false;
            }
        }
        private void buttonToAddForm_Click(object sender, EventArgs e)
        {
            ItemAddForm itemAddForm = new ItemAddForm(this, database);
            itemAddForm.Show();
        }
        private void buttonCheckInfo_Click(object sender, EventArgs e)
        {
            if (ArrayViev.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ArrayViev.SelectedRows[0];
                FullInfo fullInfo = new FullInfo(database, selectedRow);
                fullInfo.Show();
            }
            else
            {
                MessageBox.Show("Виберіть рядок для перегляду деталей!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            if (ArrayViev.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Впевнені у видаленні?", "Підтвердіть", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = ArrayViev.SelectedRows[0];
                    int itemId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    Item item = database.GetItemById(itemId);

                    if (item != null)
                    {
                        database.Items.Remove(item);
                        DatabaseManager.SaveData(database);
                        RefreshDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Виберіть рядок для видалення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Виберіть рядок для видалення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonRefound_Click(object sender, EventArgs e)
        {
            if (ArrayViev.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Впевнені у поверненні?", "Підтвердіть", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = ArrayViev.SelectedRows[0];
                    int itemId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    Item item = database.GetItemById(itemId);

                    if (item != null)
                    {
                        item.Status = ItemStatus.Повернено;
                        item.SaleReturnDate = DateTime.Now;
                        DatabaseManager.SaveData(database);
                        RefreshDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Виберіть рядок", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Виберіть рядок", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonSell_Click(object sender, EventArgs e)
        {
            if (ArrayViev.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ArrayViev.SelectedRows[0];
                SellForm sellForm = new SellForm(this, database, selectedRow);
                sellForm.Show();
            }
            else
            {
                MessageBox.Show("Виберіть рядок для перегляду деталей!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ArrayViev.DataSource = database.SearchItemsByName(textBoxSearch.Text.ToString());
            FormatColumnsNames(ArrayViev);
        }
        private void buttonSearchClear_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            FilterForm filterForm = new FilterForm(this, database);
            filterForm.Show();
        }
        private void ArrayViev_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                buttonCheckInfo.PerformClick();
            }
            if (e.KeyCode == Keys.Delete)
            {
                buttonDeleteItem.PerformClick();
            }
        }

        private bool ascending = true;
        private void ArrayViev_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Item> items = database.Items;

            var column = ArrayViev.Columns[e.ColumnIndex];
            string sortColumn = column.Name;

            if (ascending)
            {
                switch (sortColumn)
                {
                    case "Id":
                        items.Sort((x, y) => x.Id.CompareTo(y.Id));
                        break;
                    case "Category":
                        items.Sort((x, y) => string.Compare(x.Category, y.Category));
                        break;
                    case "Name":
                        items.Sort((x, y) => string.Compare(x.Name, y.Name));
                        break;
                    case "EstimatedValue":
                        items.Sort((x, y) => x.EstimatedValue.CompareTo(y.EstimatedValue));
                        break;
                    case "LoanAmount":
                        items.Sort((x, y) => x.LoanAmount.CompareTo(y.LoanAmount));
                        break;
                    case "DepositDate":
                        items.Sort((x, y) => x.DepositDate.CompareTo(y.DepositDate));
                        break;
                    case "StoragePeriodDays":
                        items.Sort((x, y) => x.StoragePeriodDays.CompareTo(y.StoragePeriodDays));
                        break;
                    case "Status":
                        items.Sort((x, y) => x.Status.CompareTo(y.Status));
                        break;
                    case "ClientId":
                        items.Sort((x, y) => x.ClientId.CompareTo(y.ClientId));
                        break;
                    case "SaleReturnDate":
                        items.Sort((x, y) => x.SaleReturnDate.CompareTo(y.SaleReturnDate));
                        break;
                    case "RedemptionPrice":
                        items.Sort((x, y) => x.RedemptionPrice.CompareTo(y.RedemptionPrice));
                        break;
                    case "StatusToSaleOrReturn":
                        items.Sort((x, y) => string.Compare(x.StatusToSaleOrReturn, y.StatusToSaleOrReturn));
                        break;
                }
            }
            else
            {
                switch (sortColumn)
                {
                    case "Id":
                        items.Sort((x, y) => y.Id.CompareTo(x.Id));
                        break;
                    case "Category":
                        items.Sort((x, y) => string.Compare(y.Category, x.Category));
                        break;
                    case "Name":
                        items.Sort((x, y) => string.Compare(y.Name, x.Name));
                        break;
                    case "EstimatedValue":
                        items.Sort((x, y) => y.EstimatedValue.CompareTo(x.EstimatedValue));
                        break;
                    case "LoanAmount":
                        items.Sort((x, y) => y.LoanAmount.CompareTo(x.LoanAmount));
                        break;
                    case "DepositDate":
                        items.Sort((x, y) => y.DepositDate.CompareTo(x.DepositDate));
                        break;
                    case "StoragePeriodDays":
                        items.Sort((x, y) => y.StoragePeriodDays.CompareTo(x.StoragePeriodDays));
                        break;
                    case "Status":
                        items.Sort((x, y) => y.Status.CompareTo(x.Status));
                        break;
                    case "ClientId":
                        items.Sort((x, y) => y.ClientId.CompareTo(x.ClientId));
                        break;
                    case "SaleReturnDate":
                        items.Sort((x, y) => y.SaleReturnDate.CompareTo(x.SaleReturnDate));
                        break;
                    case "RedemptionPrice":
                        items.Sort((x, y) => y.RedemptionPrice.CompareTo(x.RedemptionPrice));
                        break;
                    case "StatusToSaleOrReturn":
                        items.Sort((x, y) => string.Compare(y.StatusToSaleOrReturn, x.StatusToSaleOrReturn));
                        break;
                }
            }


            ArrayViev.DataSource = null;
            ArrayViev.DataSource = items;
            FormatColumnsNames(ArrayViev);

            ascending = !ascending;
        }
        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearch.PerformClick();
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = ArrayViev.SelectedRows[0];
            EditForm editForm = new EditForm(this, database, selectedRow);
            editForm.Show();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (ArrayViev.SelectedRows.Count == 0)
            {
                MessageBox.Show("Виберіть рядок для друку!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = ArrayViev.SelectedRows[0];
            Item item = database.GetItemById(Convert.ToInt32(row.Cells["Id"].Value));
            Client client = database.GetClientById(item.ClientId);

            // формуємо текст квітанції
            // період збереження
            string storagePeriodText = item.StoragePeriodDays > 0
                ? $"Термін зберігання: {item.StoragePeriodDays} днів\n"
                : "";

            // денна ставка
            string percentRateText;
            if (item.LoanAmount != 0 && item.StoragePeriodDays > 0)
            {
                decimal dailyRate = Math.Round((item.EstimatedValue / item.LoanAmount - 1)
                                              / item.StoragePeriodDays * 100, 2);
                percentRateText = $"Відсоткова ставка: {dailyRate}% на день\n";
            }
            else
            {
                percentRateText = ""; // не выводимо, якщо ділити не можна
            }

            // Нараховані відсотки и Сума до повернення (не показувати, якщо продано)
            string interestText = item.Status == ItemStatus.Продано
                ? "" // не виводимо якщо статус "Продано"
                : $"Нараховані відсотки: {(item.RedemptionPrice - item.LoanAmount)} грн\n" +
                  $"Сума до повернення: {item.RedemptionPrice} грн\n";

            // покупець (якщо продано )
            string buyerText = (item.Status == ItemStatus.Продано && item.Buyer != null)
                ? $"Покупець: {item.Buyer.FullName}\nТелефон покупця: {item.Buyer.PhoneNumber}\n"
                : "";

            // дата повернення/продажи (если не на збереженні)
            string returnDateText = item.Status != ItemStatus.Зберігається
                ? $"Дата повернення/продажу: {item.SaleReturnDate:dd.MM.yyyy}\n"
                : "";

            string receiptText =
                "КВИТАНЦІЯ ЛОМБАРДУ\n" +
                "------------------------\n" +
                $"ПІБ клієнта: {client.FullName}\n" +
                $"Телефон: {client.PhoneNumber}\n" +
                $"Категорія: {item.Category}\n" +
                $"Назва предмета: {item.Name}\n" +
                $"Дата застави: {item.DepositDate:dd.MM.yyyy}\n" +
                $"Сума позики: {item.LoanAmount} грн\n" +
                $"Оціночна вартість: {item.EstimatedValue} грн\n" +
                storagePeriodText +
                percentRateText +
                interestText +
                $"Статус: {item.StatusToSaleOrReturn}\n" +
                buyerText +
                returnDateText +
                "------------------------\n" +
                "Дата друку: " + DateTime.Now.ToString("dd.MM.yyyy");

            // друк
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += (s, ev) =>
            {
                using Font font = new Font("Courier New", 12);
                ev.Graphics.DrawString(receiptText, font, Brushes.Black,
                    new RectangleF(50, 50, ev.PageBounds.Width - 100, ev.PageBounds.Height - 100));
            };

            using PrintDialog printDialog = new PrintDialog
            {
                Document = printDoc
            };
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }
    }
}