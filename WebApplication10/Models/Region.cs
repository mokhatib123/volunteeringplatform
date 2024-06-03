using System.ComponentModel.DataAnnotations;

namespace WebApplication10.Models
{
    public class Region
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Region name is mandatory")]
        public string Name { get; set; }
    }
}
