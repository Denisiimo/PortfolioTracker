namespace PortfolioTracker.Model
{
    public class Currency
    {
        public int Id { get; set; }
        public string currencyName { get; set; }
        public List<CurrencyList> currencyLists { get; set; }
    }
}
