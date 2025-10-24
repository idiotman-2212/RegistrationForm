using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Your Email")]
        public string email { get; set; }
        [Required(ErrorMessage = "Please Enter Your Phone")]
        public string phone { get; set; }
        [Required(ErrorMessage = "Please Choose If You Are Graduated Or Not")]
        public bool hasGraduate {  get; set; }
    }
}
