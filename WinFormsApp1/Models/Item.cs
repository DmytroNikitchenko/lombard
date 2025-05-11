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
        public int RedemptionPrice
        {
            get
            {
                if (Status == ItemStatus.Зберігається)
                {
                    int days = StoragePeriodDays;

                    decimal rate = (EstimatedValue / LoanAmount - 1) / days;

                    int actualDays = (DateTime.Now - DepositDate).Days;
                    if (actualDays < 0) actualDays = 0;
                    if (actualDays > days) actualDays = days; // не виходимо за межі

                    decimal interest = LoanAmount * rate * actualDays;
                    return (int)LoanAmount + (int)interest;
                }
                else
                {
                    int days = StoragePeriodDays;

                    decimal rate = (EstimatedValue / LoanAmount - 1) / days;

                    int actualDays = (SaleReturnDate - DepositDate).Days;
                    if (actualDays < 0) actualDays = 0;
                    if (actualDays > days) actualDays = days; // не виходимо за межі

                    decimal interest = LoanAmount * rate * actualDays;
                    return (int)LoanAmount + (int)interest;
                }
            }
        }
        public DateTime DepositDate { get; set; }
        public int StoragePeriodDays { get; set; }
        public ItemStatus Status { get; set; }
        public int ClientId { get; set; }
        public DateTime SaleReturnDate { get; set; }
        
    }
}
