namespace PortfolioTracker.Model
{
    public class Transaction
    {
        public int Id { get; set; }

        public string side { get; set; }

        public decimal quantity { get; set; }

        public decimal price { get; set; }

        public DateTime date { get; set; }

        public CurrencyList currencyList { get; set; }
    }
}
