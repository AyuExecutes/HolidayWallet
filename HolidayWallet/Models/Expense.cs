namespace HolidayWallet.Models
{
    /**
     * Expense class must have category, amount, and a reference to the holiday it belongs to.
     * HolidayId is a foreign key to the Holiday class so that the relationship between the two classes is established.
    */
    public class Expense
    {
        public int Id { get; set; }
        public required string Category { get; set; }
        public required decimal Amount { get; set; }
        public int HolidayId { get; set; }
        public required Holiday Holiday { get; set; }       
        public int CurrencyId { get; set; }
        public required Currency Currency { get; set; }     


    }
}
