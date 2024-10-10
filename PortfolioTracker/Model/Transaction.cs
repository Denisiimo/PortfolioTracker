namespace PortfolioTracker.Model
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Side { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public CurrencyList CurrencyList { get; set; }
    }
}
