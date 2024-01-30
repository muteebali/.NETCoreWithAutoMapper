using Automapper.console.Models;
using AutoMapper;
using AutoMapper.Execution;

namespace Automapper.console.Step.MappingProfile
{
    public class CustomValueResolverProfile:Profile
    {
        public CustomValueResolverProfile()
        {
            CreateMap<CustomValueResolver_Source, CustomValueResolver_Destination>()
                .ForMember(dest => dest.Total, src => src.MapFrom<CustomResolver>());
        }
    }

    public class CustomResolver : IValueResolver<CustomValueResolver_Source, CustomValueResolver_Destination, string>
    {
        public string Resolve(CustomValueResolver_Source source, CustomValueResolver_Destination destination, string destMember, ResolutionContext context)
        {
            return (source.ItemPrice - source.Discount).ToString("c");

        }
    }
}
