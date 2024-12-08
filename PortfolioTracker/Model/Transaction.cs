using System.ComponentModel.DataAnnotations;

namespace PortfolioTracker.Model
{
    public class Transaction
    {
        public int Id { get; set; }
        public string CurrencyName { get; set; } // Currency Name
        public string Side { get; set; } // Buy or Sell
        public decimal BuyingAmount { get; set; }
        public decimal BuyingPrice { get; set; }
        public DateTime Date { get; set; }
        public List<CurrencyList> CurrencyLists { get; set; }
    }
}
