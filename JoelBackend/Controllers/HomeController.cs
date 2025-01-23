using JoelBackend.Data;
using Microsoft.AspNetCore.Mvc;

namespace JoelBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly JoelDBContext jContext;

        public HomeController(JoelDBContext jContext)
        {
            this.jContext = jContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var student = await jContext.Students.FindAsync(1);
            return Ok("SUCCESSFUL! first student = " + student.FirstName);
        }
    }
}
