namespace HolidayWallet.Models
{
    /**
     * Holiday class must have destination name, dates, total budget, currency, and a list of expenses.
     */
    public class Holiday
    {
        public int Id { get; set; }
        public required string Destination { get; set; }
        public required string StartDate { get; set; }
        public required string EndDate { get; set; }
        public required decimal Budget { get; set; }
        public required string Currency { get; set; }
        public ICollection<Expense> Expenses { get; set; } = [];
    }
}
