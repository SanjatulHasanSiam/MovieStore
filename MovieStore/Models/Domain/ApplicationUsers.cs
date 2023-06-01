using Microsoft.AspNetCore.Identity;

namespace MovieStore.Models.Domain
{
    public class ApplicationUsers:IdentityUser
    {
        public string Name { get; set; }
    }
}
