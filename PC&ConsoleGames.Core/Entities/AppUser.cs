using Microsoft.AspNetCore.Identity;

namespace PC_ConsoleGames.Core.Entities
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}
