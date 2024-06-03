using System.ComponentModel.DataAnnotations;

namespace WebApplication10.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Skill name is mandatory")]
        public string Name { get; set; }
    }
}
