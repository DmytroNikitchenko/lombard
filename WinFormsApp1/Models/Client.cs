namespace lombard.Models
{
    [Serializable]
    public class Client //клас клієнта
    {
        public int Id { get; set; }  //id клієнта
        public string FullName { get; set; } = ""; //піб клієнта
        public string PhoneNumber { get; set; } = ""; //номер телефона клієнта
    }
}