namespace lombard.Models
{
    [Serializable]
    public class PawnshopDatabase //Клас бази даних
    {
        public List<Client> Clients { get; set; } = new List<Client>();
        public List<Item> Items { get; set; } = new List<Item>();
        public void AddItem(Item item)
        {
            Items.Add(item);
        }
        public void AddClient(Client client)
        {
            Clients.Add(client);
        }
        public List<Item> SearchItemsByName(string name)
        {
            name = name.Trim();
            if (string.IsNullOrEmpty(name))
            {
                return Items;
            }

            return Items.Where(item => item.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public Item GetItemById(int id)
        {
            return Items.FirstOrDefault(i => i.Id == id);
        }
        public Client GetClientById(int id)
        {
            return Clients.FirstOrDefault(c => c.Id == id);
        }
        public Client GetClientByFullName(string name)
        {
            return Clients.FirstOrDefault(c => c.FullName == name);
        }
    }
}
