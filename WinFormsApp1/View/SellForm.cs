using lombard.Models;

namespace lombard.View
{
    public partial class SellForm : Form
    {
        private PawnshopDatabase database;
        private Client client;
        private MainForm mainForm;
        private DataGridViewRow selectedRow;

        public SellForm(MainForm mainForm, PawnshopDatabase database, DataGridViewRow selectedRow)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.selectedRow = selectedRow;
            this.database = database;
            client = database.GetClientByFullName(textBoxFullName.Text);
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Впевнені у даних?", "Підтвердіть", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(textBoxFullName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxBuyerNumber.Text))
                {
                    MessageBox.Show("Будь ласка, заповніть усі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                client = database.GetClientByFullName(textBoxFullName.Text);
                if (client == null)
                {
                    client = new Client
                    {
                        Id = database.Clients.Count + 1,
                        FullName = textBoxFullName.Text,
                        PhoneNumber = textBoxBuyerNumber.Text
                    };
                    database.AddClient(client);
                }

                Item item = database.GetItemById(Convert.ToInt32(selectedRow.Cells["Id"].Value));
                item.Status = ItemStatus.Продано;
                item.SaleReturnDate = DateTime.Now;
                item.Buyer = client;

                DatabaseManager.SaveData(database);
                mainForm.RefreshDataGrid();
                Close();
            }
        }

        private void textBoxBuyerNumber_KeyPress(object sender, KeyPressEventArgs e)
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