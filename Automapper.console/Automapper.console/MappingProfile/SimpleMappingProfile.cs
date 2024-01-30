using Automapper.Console.Domain;
using AutoMapper;

namespace Automapper.Console.MappingProfile
{
    public class SimpleMappingProfile:Profile
    {
        public SimpleMappingProfile()
        {
            CreateMap<Source, Destination>();
        }
    }
}
