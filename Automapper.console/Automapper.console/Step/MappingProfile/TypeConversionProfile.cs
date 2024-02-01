using Automapper.Console.Domain;
using AutoMapper;
using AutoMapper.Execution;

namespace Automapper.console.Step.MappingProfile
{
    public class TypeConversionProfile : Profile
    {
        public TypeConversionProfile()
        {
            CreateMap<TypeConversion_Source, TypeConversion_Destination>();
            CreateMap<string, int>().ConvertUsing(src => Convert.ToInt32(src));
            CreateMap<string, DateTime>().ConvertUsing<CustomDateTimeConvertor>();

            //Value transformation on single type
            ValueTransformers.Add<string>(src => src + "!!!");
        }
    }

    public class CustomDateTimeConvertor : ITypeConverter<string, DateTime>
    {
        public DateTime Convert(string source, DateTime destination, ResolutionContext context) => DateTime.Parse(source);
    }
}
