using Automapper.API.Models;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Automapper Service
var mapperConfig = new MapperConfiguration(cfg => {
    cfg.CreateMap<ToDoItem, ToDoResponse>()
    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Task));
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
