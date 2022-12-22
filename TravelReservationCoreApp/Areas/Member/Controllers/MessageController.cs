using Microsoft.AspNetCore.Mvc;

namespace TravelReservationCoreApp.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
