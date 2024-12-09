namespace HolidayWallet.Models
{
    /**
     * Currency that are available to this program will be NZD (New Zealand Dollar), USD (United States Dollar), and IDR (Indonesian Rupiah).
     */
    public class Currency
    {
        public int Id { get; set; }
        public required string FromCode { get; set; }                 
        public required string ToCode { get; set; }                  
        public required decimal ConversionRate { get; set; }      // Conversion rate to NZD

    }
}
