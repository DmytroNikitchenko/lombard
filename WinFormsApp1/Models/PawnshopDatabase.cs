namespace lombard.Models
{
    [Serializable]
    public class PawnshopDatabase //Клас бази даних
    {
        public List<Client> Clients { get; set; } = new List<Client>(); //лист клієнтів
        public List<Item> Items { get; set; } = new List<Item>(); //лист предметів
        public void AddItem(Item item) //додавання предмета
        {
            Items.Add(item);
        }
        public void AddClient(Client client) // додавання клієнта
        {
            Clients.Add(client);
        }
        public List<Item> SearchItemsByName(string name) // пошук предметів по назві
        {
            name = name.Trim();
            if (string.IsNullOrEmpty(name))
            {
                return Items;
            }

            return Items.Where(item => item.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public Item GetItemById(int id) //отримання предмета по id
        {
            return Items.FirstOrDefault(i => i.Id == id);
        }
        public Client GetClientById(int id) //отримання клієнта по id
        {
            return Clients.FirstOrDefault(c => c.Id == id);
        }
        public Client GetClientByFullName(string name) //отримання клієнта по піб
        {
            return Clients.FirstOrDefault(c => c.FullName == name);
        }
    }
}