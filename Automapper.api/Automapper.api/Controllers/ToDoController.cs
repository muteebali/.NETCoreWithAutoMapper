using Automapper.API.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Automapper.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly ILogger<ToDoController> _logger;
        private readonly IMapper _mapper;

        public ToDoController(ILogger<ToDoController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public ToDoResponse Get()
        {
            return _mapper.Map<ToDoResponse>(new ToDoItem { Task = "This is my first automapper task." });
        }
    }
}
