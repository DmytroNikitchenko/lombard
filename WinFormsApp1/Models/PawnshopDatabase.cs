namespace WinFormsApp1.Models
{
    [Serializable]
    public class PawnshopDatabase //Клас бази даних
    {
        public List<Client> Clients { get; set; } = new List<Client>();
        public List<Item> Items { get; set; } = new List<Item>();
        public List<Item> SearchItemsByName(string name)
        {

            if (string.IsNullOrEmpty(name))
            {
                return Items;
            }

            return Items.Where(item => item.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
