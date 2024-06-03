using System.ComponentModel.DataAnnotations;

namespace WebApplication10.Models
{
    public class TrainingCourse
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Course name is mandatory")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is mandatory")]
        public string Description { get; set; }
    }
}
