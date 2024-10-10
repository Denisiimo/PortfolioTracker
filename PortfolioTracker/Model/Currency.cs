namespace PortfolioTracker.Model
{
    public class Currency
    {
        public int Id { get; set; }
        public string CurrencyName { get; set; }
        public List<CurrencyList> CurrencyLists { get; set; }
    }
}
