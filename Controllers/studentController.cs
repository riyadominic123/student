using Microsoft.AspNetCore.Mvc;
using WebApplication3.DTOs;
using WebApplication3.Models;
using WebApplication3.Service;


namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class studentController : ControllerBase
    {
        private readonly StudentService _service;
        public studentController(StudentService service)
        {
            _service = service;
        }
        [HttpGet]
        [HttpGet]
        public IActionResult Get()
        {
            var students = _service.GetStudents();

            var result = students.Select(s => new StudentDto
            {
                Id = s.Id,
                Name = s.Name,
                Age = s.Age,
                ClassName = s.Class != null ? s.Class.Name : null
            });

            return Ok(result);
        }
        [HttpGet("{id}")]
        public Student GetById(int id)
        {
            return _service.GetStudentById(id);
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
