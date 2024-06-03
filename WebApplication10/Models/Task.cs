using System.ComponentModel.DataAnnotations;

namespace WebApplication10.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Task name is mandatory")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public int RegionId { get; set; }
        public Region Region { get; set; }

        [Required]
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
