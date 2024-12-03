using PortfolioTracker.Model;

namespace PortfolioTracker.Context
{
    public class PortfolioValueService
    {
        private decimal _totalValue;
        public decimal TotalValue
        {
            get => _totalValue;
            set => _totalValue = value;
        }

        public decimal CalculateTotalValue(IEnumerable<CurrencyList> currencyLists, Dictionary<string, string> livePrices)
        {
            return currencyLists?.Where(c => c.Currency != null && c.Transaction != null) // Fetch all currencies
                .Sum(c => 
                {
                    decimal livePrice = livePrices.ContainsKey(c.Currency.CurrencyName)
                        ? System.Convert.ToDecimal(livePrices[c.Currency.CurrencyName])
                        : 0;
                    return livePrice > 0 ? (c.Transaction.BuyingAmount / c.Transaction.BuyingPrice) * livePrice : 0;
                }) ?? 0; // Add the currencies for which the livePrice is greater than 0
        }
    }
}
