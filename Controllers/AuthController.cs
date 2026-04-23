using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;
using WebApplication3.Models;
using WebApplication3.DTOs;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            if (model.Email == "admin@gmail.com" && model.Password == "123456")
            {
                return Ok(new { message = "Login success", apiKey = "MY_SECRET_KEY_123" });
            }

            return Unauthorized("Invalid credentials");
        }
    }
}
