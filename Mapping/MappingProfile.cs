using AutoMapper;
using vega2.Controllers.Resources;
using vega2.Models;

namespace vega2.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
        }
    }
}