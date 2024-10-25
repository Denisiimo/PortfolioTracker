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

        public async Task RemoveCurrencyListAsync(int currencyListId)
        {
            // Find the currency list entry by its ID
            var currencyList = await _context.CurrencyLists
                .Include(cl => cl.Currency) // Include related Currency
                .Include(cl => cl.Transaction) // Include related Transactions
                .FirstOrDefaultAsync(cl => cl.Id == currencyListId);

            if (currencyList != null)
            {
                // Remove linked transactions
                if (currencyList.Transaction != null)
                {
                    _context.Transactions.Remove(currencyList.Transaction);
                }

                // Remove linked currency
                if (currencyList.Currency != null)
                {
                    _context.Currencies.Remove(currencyList.Currency);
                }

                // Remove the currency list entry
                _context.CurrencyLists.Remove(currencyList);
                await _context.SaveChangesAsync(); // Save changes to the database
            }
        }

        public async Task EditCurrencyListAsync(int currencyListId)
        {
            var currencyList = await _context.CurrencyLists
                .Include(cl => cl.Currency)
                .Include(cl => cl.Transaction)
                .FirstOrDefaultAsync(cl => cl.Id == currencyListId);

            if (currencyList != null)
            {
                if (currencyList.Transaction != null)
                {

                }
                if (currencyList.Currency != null)
                {

                }
            }
        }

        public async Task UpdateCurrencyListAsync(CurrencyList currencyList)
        {
            _context.CurrencyLists.Update(currencyList);
            await _context.SaveChangesAsync();
        }

        public async Task<CurrencyList?> GetCurrencyListByIdAsync(int currencyListId)
        {
            return await _context.CurrencyLists
                .Include(cl => cl.Currency)    // Include related Currency data
                .Include(cl => cl.Transaction)  // Include related Transaction data
                .FirstOrDefaultAsync(cl => cl.Id == currencyListId);
        }
    }
}
