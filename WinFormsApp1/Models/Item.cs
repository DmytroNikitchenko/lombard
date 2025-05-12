using System.ComponentModel;

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
                DateTime endDate = DepositDate.AddDays(StoragePeriodDays);
                DateTime currentDate = Status == ItemStatus.Зберігається ? DateTime.Now : SaleReturnDate;

                // якщо строк зберігання вийшов викуп лише за EstimatedValue
                if (currentDate > endDate)
                {
                    return (int)EstimatedValue;
                }

                int actualDays = (currentDate - DepositDate).Days;
                decimal rate = (EstimatedValue / LoanAmount - 1) / StoragePeriodDays;
                decimal interest = LoanAmount * rate * actualDays;

                return (int)(LoanAmount + interest);
            }
        }
        public DateTime DepositDate { get; set; }
        public int StoragePeriodDays { get; set; }
        public string StatusToSaleOrReturn
        {
            get
            {
                if (Status == ItemStatus.Продано)
                {
                    return "Продано";
                }
                else if (Status == ItemStatus.Повернено)
                {
                    return "Повернено";
                }
                else
                {
                    DateTime endDate = DepositDate.AddDays(StoragePeriodDays);
                    return DateTime.Now <= endDate ? "Чекає на повернення" : "Продається";
                }
            }
        }
        public ItemStatus Status { get; set; }
        public int ClientId { get; set; }        
        public DateTime SaleReturnDate { get; set; }

        [Browsable(false)]
        public Client Buyer { get; set; }                      
    }
}