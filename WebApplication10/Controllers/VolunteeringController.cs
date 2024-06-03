using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication10.Models; // Add this line

namespace WebApplication10.Controllers
{
    public class VolunteeringController : Controller
    {
        public ActionResult VolunteerForm()
        {
            var regions = new List<Region>
            {
                new Region { Id = 1, Name = "Region 1" },
                new Region { Id = 2, Name = "Region 2" }
            };

            var skills = new List<Skill>
            {
                new Skill { Id = 1, Name = "Skill 1" },
                new Skill { Id = 2, Name = "Skill 2" }
            };

            ViewBag.Regions = new SelectList(regions, "Id", "Name");
            ViewBag.Skills = new SelectList(skills, "Id", "Name");

            return View(new VolunteeringFormViewModel());
        }
        [HttpPost]
        public ActionResult SubmitVolunteerForm(VolunteeringFormViewModel model)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("Submitted Volunteer Form:");
                Console.WriteLine($"RegionId: {model.RegionId}");
                Console.WriteLine($"SkillId: {model.SkillId}");
                Console.WriteLine($"StudentName: {model.StudentName}");
                Console.WriteLine($"StudentEmail: {model.StudentEmail}");
                Console.WriteLine($"StudentPhone: {model.StudentPhone}");
                Console.WriteLine($"University: {model.University}");
                Console.WriteLine($"Major: {model.Major}");
                Console.WriteLine($"TaskName: {model.TaskName}");
                Console.WriteLine($"TaskDescription: {model.TaskDescription}");
                Console.WriteLine($"TaskRegionId: {model.TaskRegionId}");

                return RedirectToAction("VolunteerSuccess");
            }

            return View("VolunteerForm", model);
        }
    }
}
