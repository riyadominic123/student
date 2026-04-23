using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Service;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class classController : ControllerBase
    {
        [HttpGet]
        public List<Class> GetClasses()
        {
            return new List<Class>
            {
                new Class { Id = 1, Name = "BCA" },
                new Class { Id = 2, Name = "MCA" },
                new Class { Id = 3, Name = "BSc" }
            };
        }
    }
}