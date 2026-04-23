using WebApplication3.Models;
using WebApplication3.Repo;
namespace WebApplication3.Service
{
    public class StudentService
    {
        private readonly StudentRepo _repo;

        public StudentService(StudentRepo repo)
        {
            _repo = repo;
        }

        public List<Student> GetStudents()
        {
            return _repo.GetAll();
        }

        public Student GetStudentById(int id)
        {
            return _repo.GetById(id);
        }

        public Student CreateStudent(Student student)
        {
            return _repo.Add(student);
        }

        public void UpdateStudent(int id, Student student)
        {
            _repo.Update(id, student);
        }

        public void DeleteStudent(int id)
        {
            _repo.Delete(id);
        }
    }
}
