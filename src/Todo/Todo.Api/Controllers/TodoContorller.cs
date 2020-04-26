using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Todo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoContorller : ControllerBase
    {
        private readonly ILogger<TodoContorller> _logger;

        public TodoContorller(ILogger<TodoContorller> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<string> Get(string name = "World")
        {
            _logger.LogInformation("Greeting {Name}", name);
            return Ok($"Hello, {name}!");
        }
    }
}
