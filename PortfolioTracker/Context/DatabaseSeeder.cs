

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

            if (!_context.Currencies.Any())
            {
                var currencies = GetCurrencies();
                _context.Currencies.AddRange(currencies);
                await _context!.SaveChangesAsync();
            }
        }

        private List<Currency> GetCurrencies()
        {
            return
            [
                new Currency { CurrencyName  = "BTC"},
                new Currency { CurrencyName  = "SOL"},
                new Currency { CurrencyName  = "ARB"}
            ];
        }
    }
}
