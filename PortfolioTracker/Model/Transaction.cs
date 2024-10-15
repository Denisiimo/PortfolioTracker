namespace PortfolioTracker.Model
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Side { get; set; } // Buy or Sell
        public decimal Quantity { get; set; }

        //public decimal Price { get; set; } 
        // Not needed as the price is fetched on the client side using API
        public DateTime Date { get; set; }
        public CurrencyList CurrencyList { get; set; }
    }
}
