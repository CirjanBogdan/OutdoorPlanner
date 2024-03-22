using AutoMapper;
using OutdoorPlanner.Models;
using OutdoorPlanner.ViewModels;

namespace OutdoorPlanner.AutoMapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Event, EventViewModel>().ReverseMap();
            CreateMap<Event, CreateEventBindingModel>().ReverseMap();

            CreateMap<Invitation, InvitationViewModel>().ReverseMap();
            CreateMap<Invitation, CreateInvitationBindingModel>().ReverseMap();

            CreateMap<EventViewModel, InvitationsEventViewModel>().ReverseMap();
            CreateMap<CreateInvitationBindingModel, InvitationsEventViewModel>().ReverseMap();

            CreateMap<Event, InvitationsEventViewModel>().ReverseMap();
        }
    }
}
