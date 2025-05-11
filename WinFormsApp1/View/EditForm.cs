using lombard.Models;

namespace lombard.View
{
    public partial class EditForm : Form
    {
        private Item itemToEdit;
        private PawnshopDatabase database;
        private MainForm mainForm;
        private Client client;
        public EditForm(MainForm mainForm, PawnshopDatabase database, DataGridViewRow row)
        {
            InitializeComponent();

            int ItemId = Convert.ToInt32(row.Cells["Id"].Value);

            this.database = database;
            itemToEdit = database.GetItemById(ItemId);
            this.mainForm = mainForm;
            this.client = database.GetClientById(itemToEdit.ClientId);

            textBoxItemName.Text = itemToEdit.Name;
            textBoxEstimatedValue.Text = itemToEdit.EstimatedValue.ToString();
            textBoxLoanAmount.Text = itemToEdit.LoanAmount.ToString();
            textBoxStoragePeriodDays.Text = itemToEdit.StoragePeriodDays.ToString();
            comboBoxCategories.SelectedItem = itemToEdit.Category;
            textBoxFullName.Text = client.FullName;
            textBoxPhone.Text = client.PhoneNumber;
        }

        private void EditItemButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(textBoxItemName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxFullName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxEstimatedValue.Text) ||
                    string.IsNullOrWhiteSpace(textBoxLoanAmount.Text) ||
                    string.IsNullOrWhiteSpace(textBoxStoragePeriodDays.Text) ||
                    string.IsNullOrWhiteSpace(textBoxPhone.Text) ||
                    comboBoxCategories.SelectedIndex == -1)
                {
                    MessageBox.Show("Будь ласка, заповніть усі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Convert.ToInt32(textBoxEstimatedValue.Text) < Convert.ToInt32(textBoxLoanAmount.Text))
                {
                    MessageBox.Show("Оціночна вартість має бути більше або дорівнювати сумі кредиту", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (client != null)
                {
                    client.FullName = textBoxFullName.Text;
                    client.PhoneNumber = textBoxPhone.Text;
                }

                itemToEdit.Name = textBoxItemName.Text;
                itemToEdit.EstimatedValue = Convert.ToInt32(textBoxEstimatedValue.Text);
                itemToEdit.LoanAmount = Convert.ToInt32(textBoxLoanAmount.Text);
                itemToEdit.StoragePeriodDays = Convert.ToInt32(textBoxStoragePeriodDays.Text);
                itemToEdit.Category = comboBoxCategories.SelectedItem.ToString();

                DatabaseManager.SaveData(database);

                mainForm.RefreshDataGrid();
            }
        }
        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void textBoxFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
    }
}
