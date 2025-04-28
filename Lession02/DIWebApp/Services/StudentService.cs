using DIWebApp.Models;

namespace DIWebApp.Services
{
    public class StudentService : IStudentService
    {
        static List<Student> students = new List<Student>()
        {
            new Student(){Id = 1, Name = "Le Van An", Phone = "0913455555"},
            new Student(){Id = 2, Name = "Hoang Dung", Phone ="0904555666"},
            new Student(){Id = 3, Name = "Nguyen Son", Phone ="0903444555"}
        };
        public List<Student> GetAllStudents()
        {
            return students;
        }
    }
}
