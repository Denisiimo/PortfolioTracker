using Microsoft.AspNetCore.Identity;

namespace PortfolioTracker.Model
{
    public class User : IdentityUser
    {
        // Username and password is handled by IdentityUser
        public List<CurrencyList> CurrencyLists { get; set; }
    }
}
