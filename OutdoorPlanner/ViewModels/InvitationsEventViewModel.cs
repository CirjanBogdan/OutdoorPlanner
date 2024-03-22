namespace OutdoorPlanner.ViewModels
{
    public class InvitationsEventViewModel
    {
        public EventViewModel EventViewModel { get; set; }
        public IEnumerable<InvitationViewModel> InvitationListViewModel { get; set; }
    }
}
