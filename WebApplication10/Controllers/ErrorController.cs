using Microsoft.AspNetCore.Mvc;

namespace WebApplication8.Controllers
{
    public class ErrorController : Controller
    {
        // GET: ErrorController
        public ActionResult Index()
        {
            return View("Error");
        }
    }
}