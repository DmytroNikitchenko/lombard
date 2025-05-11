using lombard.Models;

namespace lombard.View
{
    public partial class FilterForm : Form //форма для фільтрації
    {
        private PawnshopDatabase database;
        private MainForm mainForm;
        public FilterForm(MainForm mainForm, PawnshopDatabase database)
        {
            InitializeComponent();
            this.database = database;
            this.mainForm = mainForm;
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            string nameFilter = textBoxName.Text.Trim();
            string? selectedCategory = comboBoxCategory.SelectedItem?.ToString();
            string? selectedStatus = comboBoxStorageStatus.SelectedItem?.ToString();
            string? selectedStatusForSaleOrReturn = comboBoxStatusForSaleOrReturn.SelectedItem?.ToString();

            decimal minValue = numericMinEstimatedValue.Value;
            decimal maxValue = numericMaxEstimatedValue.Value;

            DateTime dateFrom = datePickerFromDate.Value.Date;
            DateTime dateTo = datePickerToDate.Value.Date;

            var filtered = database.Items.AsEnumerable();

            // Ім'я
            if (!string.IsNullOrWhiteSpace(nameFilter))
            {
                filtered = filtered.Where(item => item.Name.Contains(nameFilter, StringComparison.OrdinalIgnoreCase));
            }

            // Категорія
            if (selectedCategory != "Усі" && comboBoxCategory.SelectedIndex != -1)
            {
                filtered = filtered.Where(item => item.Category == selectedCategory);
            }
            // Статус
            if (selectedStatus != "Усі" && Enum.TryParse<ItemStatus>(selectedStatus, out var status))
            {
                filtered = filtered.Where(item => item.Status == status);
            }
            // статус для продажу
            if (selectedStatusForSaleOrReturn != "Усі" && comboBoxCategory.SelectedIndex != -1)
            {
                filtered = filtered.Where(item => item.StatusToSaleOrReturn == selectedStatusForSaleOrReturn);
            }
            // Оціночна вартість
            filtered = filtered.Where(item => item.EstimatedValue >= minValue && item.EstimatedValue <= maxValue);

            // Дата закладу
            filtered = filtered.Where(item => item.DepositDate.Date >= dateFrom && item.DepositDate.Date <= dateTo);

            mainForm.RefreshDataCustom(filtered.ToList());
        }
    }
}
