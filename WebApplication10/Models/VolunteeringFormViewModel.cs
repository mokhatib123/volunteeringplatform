using System.ComponentModel.DataAnnotations;

namespace WebApplication10.Models
{
    public class VolunteeringFormViewModel
    {
        [Required(ErrorMessage = "Please select a region.")]
        public int RegionId { get; set; }

        [Required(ErrorMessage = "Please select a skill.")]
        public int SkillId { get; set; }

        [Required(ErrorMessage = "Please provide your name.")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Please provide your email.")]
        [EmailAddress(ErrorMessage = "Please provide a valid email address.")]
        public string StudentEmail { get; set; }

        [Required(ErrorMessage = "Please provide your phone number.")]
        [Phone(ErrorMessage = "Please provide a valid phone number.")]
        public string StudentPhone { get; set; }

        public string University { get; set; }
        public string Major { get; set; }

        [Required(ErrorMessage = "Please provide a task name.")]
        public string TaskName { get; set; }

        [Required(ErrorMessage = "Please provide a task description.")]
        public string TaskDescription { get; set; }

        public int TaskRegionId { get; set; }
    }
}
