using Microsoft.AspNetCore.Mvc;

namespace TripTrackerAPI.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
