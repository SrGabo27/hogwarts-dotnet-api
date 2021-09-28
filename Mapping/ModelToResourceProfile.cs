using AutoMapper;
using hogwartsApi.Domain.Models;
using hogwartsApi.Resources;

namespace hogwartsApi.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Application, ApplicationResource>();
        }
    }
}
