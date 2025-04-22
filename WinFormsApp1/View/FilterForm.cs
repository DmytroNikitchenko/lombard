using lombard.Models;

namespace lombard.View
{
    public partial class FilterForm : Form //форма для фільтрації
    {
        PawnshopDatabase database;
        MainForm mainForm;
        public FilterForm(MainForm mainForm, PawnshopDatabase database)
        {
            InitializeComponent();
            this.database = database;
            this.mainForm = mainForm;
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            string nameFilter = textBoxSearchName.Text.Trim();
            string selectedCategory = comboBoxCategory.SelectedItem?.ToString();
            string selectedStatus = comboBoxStatus.SelectedItem?.ToString();

            decimal minValue = numericUpDownMinValue.Value;
            decimal maxValue = numericUpDownMaxValue.Value;

            DateTime dateFrom = dateTimePickerFrom.Value.Date;
            DateTime dateTo = dateTimePickerTo.Value.Date;

            var filtered = database.Items.AsEnumerable();

            // Ім'я
            if (!string.IsNullOrWhiteSpace(nameFilter))
            {
                filtered = filtered.Where(item => item.Name.Contains(nameFilter, StringComparison.OrdinalIgnoreCase));
            }

            // Категорія
            if (selectedCategory != "Усі")
            {
                filtered = filtered.Where(item => item.Category == selectedCategory);
            }
            // Статус
            if (selectedStatus != "Усі" && Enum.TryParse<ItemStatus>(selectedStatus, out var status))
            {
                filtered = filtered.Where(item => item.Status == status);
            }
            // Оціночна вартість
            filtered = filtered.Where(item => item.EstimatedValue >= minValue && item.EstimatedValue <= maxValue);

            // Дата закладу
            filtered = filtered.Where(item => item.DepositDate.Date >= dateFrom && item.DepositDate.Date <= dateTo);

            mainForm.RefreshDataCustom(filtered.ToList());
        }
    }
}
