using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PortfolioTracker.Model;

namespace PortfolioTracker.Context
{
    public class DatabaseContext : IdentityDbContext<User>
    {
        private IWebHostEnvironment _environment;

        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CurrencyList> CurrencyLists { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Graph> Graphs { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        //{
        //    var folder = Environment.SpecialFolder.MyDocuments;
        //    var path = Environment.GetFolderPath(folder);
        //    var dbPath = Path.Join(path, "currencybase.db");
        //    optionbuilder.UseSqlite($"Data Source={dbPath}");
        //}
        public DatabaseContext(DbContextOptions<DatabaseContext> options, IWebHostEnvironment environment) : base(options)
        {
            _environment = environment;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            var folder = Path.Combine(_environment.WebRootPath, "database");
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            optionbuilder.UseSqlite($"Data Source={folder}/portfolio.db");
        }
    }
}
