using Microsoft.CodeAnalysis.Elfie.Diagnostics;

namespace RegistrationForm.Models
{
    public static class Repository
    {
        public static List<Student> students = new List<Student>();
        public static List<Student> GetStudents()
        {
            return students;
        }
        public static void AddStudent(Student student)
        {
            students.Add(student);
        }
    }
}
