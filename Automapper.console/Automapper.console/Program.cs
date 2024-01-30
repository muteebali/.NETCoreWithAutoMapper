using Automapper.Console.Domain;
using Automapper.Console.MappingProfile;
using AutoMapper;
using FluentAssertions;

//Mapping Profiles
var mapperConfig = new MapperConfiguration(cfg =>
{
    cfg.AddProfile<SimpleMappingProfile>();
});

var mapper = mapperConfig.CreateMapper();

//Simple Conversion
var destination = mapper.Map<Destination>(new Source { Latitude = 2 });

destination.Latitude.Should().Be(2);

Console.ReadLine();

