using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Service;
namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class studentController : ControllerBase
    {
        private readonly StudentService _service;
        public studentController()
        {
            _service = new StudentService();
        }
        [HttpGet]
        public List<Student> Get()
        {
            return _service.GetStudents();
        }
        [HttpPost]
        public Student CreateStudent(Student student)
        {
            return _service.CreateStudent(student);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, Student student)
        {
            _service.UpdateStudent(id, student);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.DeleteStudent(id);
            return Ok();
        }

    }
}
