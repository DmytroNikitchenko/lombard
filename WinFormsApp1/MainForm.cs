using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private PawnshopDatabase database;
        public MainForm()
        {
            InitializeComponent();
            database = DatabaseManager.LoadData();
            ArrayViev.DataSource = database.Items;
            this.ArrayViev.SelectionChanged += new System.EventHandler(this.ArrayViev_SelectionChanged);

            FormatColumnsNames(ArrayViev);
        }
        public static void FormatColumnsNames(DataGridView dataGridView)
        {
            dataGridView.Columns["Id"].HeaderText = "ID";
            dataGridView.Columns["Name"].HeaderText = "Назва";
            dataGridView.Columns["EstimatedValue"].HeaderText = "Оцінка";
            dataGridView.Columns["LoanAmount"].HeaderText = "Сума кредиту";
            dataGridView.Columns["DepositDate"].HeaderText = "Дата внеску";
            dataGridView.Columns["StoragePeriodDays"].HeaderText = "Строк зберігання (дн.)";
            dataGridView.Columns["Status"].HeaderText = "Статус";
            dataGridView.Columns["ClientId"].HeaderText = "ID клієнта";
            dataGridView.Columns["SaleReturnDate"].HeaderText = "Дата продажу/повернення";
        }

        public void RefreshDataGrid()
        {
            database = DatabaseManager.LoadData();
            ArrayViev.DataSource = database.Items;
        }


        private void ArrayViev_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            ItemAddForm itemAddForm = new ItemAddForm(this);
            itemAddForm.Show();
        }

        private void buttonCheckInfo_Click(object sender, EventArgs e)
        {
            if (ArrayViev.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = ArrayViev.SelectedRows[0];
                FullInfo fullInfo = new FullInfo(selectedRow, database);
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
                    var item = database.Items.FirstOrDefault(i => i.Id == itemId);

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
                    var item = database.Items.FirstOrDefault(i => i.Id == itemId);

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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            if (ArrayViev.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Впевнені у продажі?", "Підтвердіть", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = ArrayViev.SelectedRows[0];
                    int itemId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    var item = database.Items.FirstOrDefault(i => i.Id == itemId);

                    if (item != null)
                    {
                        item.Status = ItemStatus.Продано;
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ArrayViev.DataSource = database.SearchItemsByName(textBoxSearch.Text.ToString());
            FormatColumnsNames(ArrayViev);
        }

        private void buttonSearchClear_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }
    }
}
