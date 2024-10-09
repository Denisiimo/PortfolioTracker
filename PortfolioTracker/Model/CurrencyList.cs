namespace PortfolioTracker.Model
{
    public class CurrencyList
    {
        public int Id { get; set; }
        public User user { get; set; }
        public Currency currency { get; set; }
        public List<Transaction> transactions { get; set; }
    }
}
