using Microsoft.AspNetCore.Identity;

namespace OutdoorPlanner.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Event>? Events { get; set; }
    }
}
