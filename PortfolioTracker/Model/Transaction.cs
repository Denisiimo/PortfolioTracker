using System.ComponentModel.DataAnnotations;

namespace PortfolioTracker.Model
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Side { get; set; } // Buy or Sell

        [Required]
        public decimal Quantity { get; set; }

        [Required]
        public decimal BuyingPrice { get; set; }

        //public decimal Price { get; set; } 
        // Not needed as the price is fetched on the client side using API
        public DateTime Date { get; set; }
        public int CurrencyId { get; set; }
        public CurrencyList CurrencyList { get; set; }
    }
}
