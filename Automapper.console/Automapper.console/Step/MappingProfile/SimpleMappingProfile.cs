using Automapper.Console.Domain;
using AutoMapper;

namespace Automapper.console.Step.MappingProfile
{
    public class SimpleMappingProfile : Profile
    {
        public SimpleMappingProfile()
        {
            CreateMap<SimpleConversion_Source, SimpleConversion_Destination>();
        }
    }
}
