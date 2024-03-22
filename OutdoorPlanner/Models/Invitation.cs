using OutdoorPlanner.Models.Enum;

namespace OutdoorPlanner.Models
{
    public class Invitation
    {
        public int Id { get; set; }
        public string? UserEmail { get; set; }

        public InvitationStatus? Status { get; set; }

        public int EventId { get; set; }
        public Event? Event { get; set; }

        public ICollection<UserInvitation>? UserInvitation { get; set; }
    }
}
