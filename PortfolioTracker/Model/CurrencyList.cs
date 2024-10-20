namespace PortfolioTracker.Model
{
    public class CurrencyList
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Currency Currency { get; set; }
        public Transaction Transaction { get; set; }
    }
}
