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
            CreateMap<Event, EventViewModel>().ReverseMap();
        }
    }
}
