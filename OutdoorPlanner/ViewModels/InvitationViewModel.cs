using OutdoorPlanner.Models.Enum;
using OutdoorPlanner.Models;

namespace OutdoorPlanner.ViewModels
{
    public class InvitationViewModel
    {
        public int Id { get; set; }
        public string UserEmail { get; set; }
        public InvitationStatus Status { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public string? EventName { get; set; }
    }
}
