using Microsoft.AspNetCore.Mvc;

namespace TravelReservationCoreApp.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404(int? code)
        {
            return View();
        }
    }
}
