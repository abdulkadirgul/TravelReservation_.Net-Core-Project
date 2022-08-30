using Microsoft.AspNetCore.Mvc;

namespace TravelReservationCoreApp.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
