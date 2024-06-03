using System.ComponentModel.DataAnnotations;

namespace WebApplication10.Models
{
    public class Student
    {
        [Key]  // Explicitly specifying the primary key
        public int Id { get; set; }

        [Required(ErrorMessage = "Student name is mandatory")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is mandatory")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is mandatory")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }

        public string University { get; set; }
        public string Major { get; set; }
    }
}
