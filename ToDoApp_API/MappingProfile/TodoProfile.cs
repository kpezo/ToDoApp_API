using AutoMapper;
using ToDoApp_API.Models;
using ToDoApp_API.Models.Rresponse;

namespace ToDoApp_API.MappingProfile
{
    public class TodoProfile : Profile
    {
        public TodoProfile() 
        {
            CreateMap<Todo, TaskListResponse>()
                .ForMember(tlr => tlr.id, m => m.MapFrom(t => t.Id))
                .ForMember(tlr => tlr.Name, m => m.MapFrom(t => t.Name));
        }
    }
}
