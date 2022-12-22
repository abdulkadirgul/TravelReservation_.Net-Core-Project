using Microsoft.AspNetCore.Mvc;

namespace TravelReservationCoreApp.Areas.Member.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
