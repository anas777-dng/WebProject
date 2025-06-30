using AutoMapper;
using UniVerseEvents.Application.DTOs;
using UniVerseEvents.Domain.Entities;

namespace UniVerseEvents.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // From Entity to DTO
            CreateMap<Event, EventDto>();

            // From DTO to Entity
            CreateMap<CreateEventDto, Event>();
        }
    }
}