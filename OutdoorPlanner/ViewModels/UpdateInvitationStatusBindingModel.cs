using OutdoorPlanner.Models.Enum;

namespace OutdoorPlanner.ViewModels
{
    public class UpdateInvitationStatusBindingModel
    {
        public int Id { get; set; }
        public int InvitationId { get; set; }
        public InvitationStatus Status { get; set; }
        public string? EventName { get; set; }
    }
}
