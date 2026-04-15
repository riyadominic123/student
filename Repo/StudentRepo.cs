using WebApplication3.Models;

namespace WebApplication3.Repo
{
    public class StudentRepo
    {
        private static List<Student> students = new List<Student>();

        public List<Student> GetAll()
        {
            return students;
        }

        public Student Add(Student student)
        {
            students.Add(student);
            return student;
        }
        public void Update(int id,Student updatedStudent)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if(student !=null)
            {
                student.Name = updatedStudent.Name;
                student.Age = updatedStudent.Age;
            }
        }
        public void Delete(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if( student != null )
            {
                students.Remove(student);
            }
        }

    }
}
