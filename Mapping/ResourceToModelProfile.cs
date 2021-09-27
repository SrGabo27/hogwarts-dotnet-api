using AutoMapper;
using hogwartsApi.Domain.Models;
using hogwartsApi.Resources;

namespace hogwartsApi.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveApplicationResource, Application>();
        }
    }
}
