using OutdoorPlanner.Models.Enum;
using OutdoorPlanner.Models;

namespace OutdoorPlanner.ViewModels
{
    public class CreateInvitationBindingModel
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string UserEmail { get; set; } = null!;
        public InvitationStatus Status { get; set; }
    }
}
