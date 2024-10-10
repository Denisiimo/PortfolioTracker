using Microsoft.AspNetCore.Identity;

namespace PortfolioTracker.Model
{
    public class User : IdentityUser
    {
        public List<CurrencyList> CurrencyLists { get; set; }
    }
}
