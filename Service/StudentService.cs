using WebApplication3.Models;
using WebApplication3.Repo;
namespace WebApplication3.Service
{
    public class StudentService
    {
        private readonly StudentRepo _repository;
        public StudentService()
        {
            _repository = new StudentRepo();
        }
        public List<Student> GetStudents()
        {
            return _repository.GetAll();
        }
        public Student CreateStudent(Student student)
        {
            return _repository.Add(student);
        }
        public void UpdateStudent(int id,Student student)
        {
            _repository.Update(id, student);

        }
        public void DeleteStudent(int id)
        {
            _repository.Delete(id);
        }
    }
}
