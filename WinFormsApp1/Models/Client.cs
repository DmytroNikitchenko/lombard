namespace WinFormsApp1.Models
{
    [Serializable]
    public class Client //клас клієнта
    {
        public int Id { get; set; }
        public string FullName { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
    }
}
