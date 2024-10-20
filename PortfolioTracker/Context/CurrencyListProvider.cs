using Microsoft.EntityFrameworkCore;
using PortfolioTracker.Context;


namespace PortfolioTracker.Model
{
    public class CurrencyListProvider
    {
        private readonly DatabaseContext _context;

        public CurrencyListProvider(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<CurrencyList>> GetAllCurrencyListsAsync()
        {
            return await _context.CurrencyLists
                .Include(x => x.Currency) 
                .Include(x => x.Transaction) 
                .ToListAsync();
        }

        public async Task AddCurrencyListAsync(CurrencyList currencyList)
        {
            _context.CurrencyLists.Add(currencyList);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveCurrencyListAsync(CurrencyList currencyList)
        {
            _context.CurrencyLists.Remove(currencyList);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCurrencyListAsync(CurrencyList currencyList)
        {
            _context.CurrencyLists.Update(currencyList);
            await _context.SaveChangesAsync();
        }
    }
}
