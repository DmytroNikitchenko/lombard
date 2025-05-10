namespace lombard.Models
{
    [Serializable]
    public class Item //клас предмета
    {
        public int Id { get; set; }
        public string Category { get; set; } = "";
        public string Name { get; set; } = "";
        public decimal EstimatedValue { get; set; }
        public decimal LoanAmount { get; set; }
        public DateTime DepositDate { get; set; }
        public int StoragePeriodDays { get; set; }
        public ItemStatus Status { get; set; }
        public int ClientId { get; set; }
        public DateTime SaleReturnDate { get; set; }

    }
}
