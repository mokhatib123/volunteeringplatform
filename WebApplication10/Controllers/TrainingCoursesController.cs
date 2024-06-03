using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication10.Models;
using WebApplication10.Services;

namespace WebApplication10.Controllers
{
    public class TrainingCoursesController : Controller
    {
        private readonly ApiService _apiService;

        public TrainingCoursesController(ApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<IActionResult> Index()
        {
            var trainingCourses = await _apiService.GetTrainingCoursesAsync();
            return View(trainingCourses);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TrainingCourse trainingCourse)
        {
            if (ModelState.IsValid)
            {
                await _apiService.CreateTrainingCourseAsync(trainingCourse);
                return RedirectToAction(nameof(Index));
            }
            return View(trainingCourse);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var trainingCourse = await _apiService.GetTrainingCourseAsync(id);
            return View(trainingCourse);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TrainingCourse trainingCourse)
        {
            if (ModelState.IsValid)
            {
                await _apiService.UpdateTrainingCourseAsync(trainingCourse);
                return RedirectToAction(nameof(Index));
            }
            return View(trainingCourse);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var trainingCourse = await _apiService.GetTrainingCourseAsync(id);
            return View(trainingCourse);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _apiService.DeleteTrainingCourseAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
