using Microsoft.AspNetCore.Identity;

namespace OutdoorPlanner.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Event>? Events { get; set; }
        
        public ICollection<UserInvitation>? UserInvitations { get; set;}

        public ICollection<Post>? Posts { get; set;}
    }       
}
