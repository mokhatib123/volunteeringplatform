using System.ComponentModel.DataAnnotations;

namespace WebApplication10.Models
{
    public class VolunteeringForm
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int RegionId { get; set; }
        public Region Region { get; set; }

        [Required]
        public int SkillId { get; set; }
        public Skill Skill { get; set; }

        [Required]
        public int StudentId { get; set; }
        public Student Student { get; set; }

        [Required(ErrorMessage = "Task name is mandatory")]
        public string TaskName { get; set; }

        [Required(ErrorMessage = "Task description is mandatory")]
        public string TaskDescription { get; set; }
    }
}
