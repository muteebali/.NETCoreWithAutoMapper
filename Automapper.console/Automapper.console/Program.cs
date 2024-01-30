using Automapper.console.Models;
using Automapper.console.Step.MappingProfile;
using Automapper.Console.Domain;
using AutoMapper;
using FluentAssertions;

//Mapping Profiles
var mapperConfig = new MapperConfiguration(cfg =>
{
    cfg.AddProfile<SimpleMappingProfile>();
    cfg.AddProfile<TypeConversionProfile>();
    cfg.AddProfile<CustomValueResolverProfile>();
});

var mapper = mapperConfig.CreateMapper();

//Simple Conversion
var destination = mapper.Map<SimpleConversion_Destination>(new SimpleConversion_Source { Latitude = 2 });
destination.Latitude.Should().Be(2);

//Type Conversion
var destination2 = mapper.Map<TypeConversion_Destination>(new TypeConversion_Source { Latitude = "22", Days = "1", Hours = "3" });
destination2.Latitude.Should().Be(22);
var destination3 = mapper.Map<TypeConversion_Destination>(new TypeConversion_Source { Date = "12/01/23" });
Console.WriteLine(destination3.Date?.GetType());

//Collection and Arrays
var sourceCollection = new [] {
    new SimpleConversion_Source{ Days=1, Hours=2,Latitude=1},
    new SimpleConversion_Source{ Days=1, Hours=2,Latitude=1},
    new SimpleConversion_Source{ Days=1, Hours=2,Latitude=1},
 };
var destination4 = mapper.Map<SimpleConversion_Source[]>(sourceCollection);
var destination5 = mapper.Map<SimpleConversion_Source[]>(sourceCollection);

//Value Resolver
var sourceCustomValue = new CustomValueResolver_Source { Discount = 10, ItemPrice = 200 };
var destination6 = mapper.Map<CustomValueResolver_Destination>(sourceCustomValue);
Console.WriteLine(destination6.Total);

Console.ReadLine();

