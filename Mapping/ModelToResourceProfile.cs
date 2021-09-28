using AutoMapper;
using hogwartsApi.Extensions;
using hogwartsApi.Domain.Models;
using hogwartsApi.Resources;

namespace hogwartsApi.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Application, ApplicationResource>()
              .ForMember(src => src.House,
                         opt => opt.MapFrom(src => src.House.ToDescriptionString()));
        }
    }
}
