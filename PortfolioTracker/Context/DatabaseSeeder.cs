using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PortfolioTracker.Model;

namespace PortfolioTracker.Context
{
    public class DatabaseSeeder
    {
        private readonly DatabaseContext _context;

        public DatabaseSeeder (DatabaseContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            await _context.Database.MigrateAsync();

            if (!_context.CurrencyLists.Any())
            {
                var currencyLists = GetCurrencyLists();
                _context.CurrencyLists.AddRange(currencyLists);
                await _context.SaveChangesAsync();
            }
        }

        private List<CurrencyList> GetCurrencyLists()
        {
            return new List<CurrencyList>
            {
                new CurrencyList
                {
                    Currency = new Currency { CurrencyName = "BTC" },
                    Transaction = new Transaction { BuyingAmount = 4000, BuyingPrice = 45000, Side = "Buy", Date = DateTime.Now }
                },
                new CurrencyList
                {
                    Currency = new Currency { CurrencyName = "SOL" },
                    Transaction = new Transaction { BuyingAmount = 1000, BuyingPrice = 130, Side = "Buy", Date = DateTime.Now }
                },
                new CurrencyList
                {
                    Currency = new Currency { CurrencyName = "ARB" },
                    Transaction = new Transaction { BuyingAmount = 300, BuyingPrice = 1.2M, Side = "Buy", Date = DateTime.Now }
                }
            };
        }
    }
}
