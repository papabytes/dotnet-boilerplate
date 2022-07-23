using Microsoft.AspNetCore.Mvc;

namespace Example.Code.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return await Task.FromResult(Ok());
        }
        
        [HttpGet("{name}")]
        public async Task<ActionResult<string>> GetAsync(string name)
        {
            var result = $"You wrote {name}";
            return await Task.FromResult(result);
        }
    }
}