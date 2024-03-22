namespace OutdoorPlanner.Models
{
    public class UserInvitation
    {
        public string? UserId { get; set; }

        public ApplicationUser? User { get; set; }

        public int InvitationId { get; set; }

        public Invitation? Invitation { get; set; }
    }
}
