using System.Data;
using lombard.Models;

namespace lombard.Viev
{
    public partial class ItemAddForm : Form //Форма додавання елементів
    {
        private MainForm mainForm;
        private PawnshopDatabase database;
        public ItemAddForm(MainForm form)
        {
            InitializeComponent();
            database = DatabaseManager.LoadData();
            mainForm = form;
        }
        private static int GetNextItemId(List<Item> items)
        {
            int newId = 1;
            var usedIds = items.Select(i => i.Id).OrderBy(id => id).ToList();

            foreach (int id in usedIds)
            {
                if (id == newId)
                {
                    newId++;
                }
                else
                {
                    break;
                }
            }

            return newId;
        }
        private void AdditemButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Впевнені у даних?", "Підтвердіть", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(textBoxItemName.Text) ||
                string.IsNullOrWhiteSpace(textBoxFullName.Text) ||
                string.IsNullOrWhiteSpace(textBoxEstimatedValue.Text) ||
                string.IsNullOrWhiteSpace(textBoxLoanAmount.Text) ||
                string.IsNullOrWhiteSpace(textBoxStoragePeriodDays.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhone.Text))
                {
                    MessageBox.Show("Будь ласка, заповніть усі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Convert.ToInt32(textBoxEstimatedValue.Text) < Convert.ToInt32(textBoxLoanAmount.Text))
                {
                    MessageBox.Show("Оціночна вартість має бути більше або дорівнювати сумі кредиту", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var client = database.Clients.FirstOrDefault(c => c.FullName == textBoxFullName.Text);
                if (client == null)
                {
                    client = new Client
                    {
                        Id = database.Clients.Count + 1,
                        FullName = textBoxFullName.Text,
                        PhoneNumber = textBoxPhone.Text
                    };
                    database.Clients.Add(client);
                }

                var newItem = new Item
                {
                    Id = GetNextItemId(database.Items),
                    Name = textBoxItemName.Text,
                    EstimatedValue = Convert.ToInt32(textBoxEstimatedValue.Text), // оціночна вартість
                    LoanAmount = Convert.ToInt32(textBoxLoanAmount.Text),  //сума кредиту
                    DepositDate = DateTime.Now,
                    StoragePeriodDays = Convert.ToInt32(textBoxStoragePeriodDays.Text),
                    Status = ItemStatus.Зберігається,
                    ClientId = client.Id,
                    Category = comboBoxCategories.SelectedItem.ToString()
                };


                database.Items.Add(newItem);

                DatabaseManager.SaveData(database);


                textBoxItemName.Clear();
                textBoxFullName.Clear();
                textBoxPhone.Clear();
                textBoxEstimatedValue.Clear();
                textBoxLoanAmount.Clear();
                textBoxStoragePeriodDays.Clear();
                comboBoxCategories.SelectedIndex = -1;

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

        private void textBoxStoragePeriodDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxLoanAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxEstimatedValue_KeyPress(object sender, KeyPressEventArgs e)
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
