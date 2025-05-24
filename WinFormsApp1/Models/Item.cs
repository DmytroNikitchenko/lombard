using System.ComponentModel;

namespace lombard.Models
{
    [Serializable]
    public class Item //клас предмета
    {
        public int Id { get; set; } //id предмета
        public string Category { get; set; } = ""; //категорія предмета
        public string Name { get; set; } = ""; //назва предмета
        public decimal EstimatedValue { get; set; } //оціночна вартість
        public decimal LoanAmount { get; set; } //сума кредиту
        public int RedemptionPrice //викупна ціна
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
        public DateTime DepositDate { get; set; } // дата внеску
        public int StoragePeriodDays { get; set; } // період збереження
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
        } //статус до продажу
        public ItemStatus Status { get; set; } //статус на складі
        public int ClientId { get; set; } //id клієнта хто внес предмет
        public DateTime SaleReturnDate { get; set; } //дата продажу/повернення

        [Browsable(false)] //не показується в datagridview
        public Client Buyer { get; set; } //покупець
    }
}