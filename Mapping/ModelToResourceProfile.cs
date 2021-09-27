using AutoMapper;
using hogwartsApi.Resources;
using hogwartsApi.Domain.Models;

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
