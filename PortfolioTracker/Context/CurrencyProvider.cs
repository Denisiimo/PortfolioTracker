﻿using Microsoft.EntityFrameworkCore;
using PortfolioTracker.Context;


namespace PortfolioTracker.Model
{
    public class CurrencyProvider
    {
        private readonly DatabaseContext _context;

        public CurrencyProvider(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<Currency>> GetAllCurrenciesAsync()
        {
            return await _context.Currencies.ToListAsync();
        }

        public async Task AddCurrencyAsync (Currency currency)
        {
            _context.Currencies.Add(currency);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCurrencyAsync(Currency currency)
        {
            _context.Currencies.Update(currency);
            await _context.SaveChangesAsync();
        }
    }
}