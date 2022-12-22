using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;


namespace TravelReservationCoreApp.ViewComponents.Default
{
    public class _Statistics : ViewComponent
    {

        public IViewComponentResult Invoke()
        {

            using var context = new Context();
            ViewBag.DestinationCount = context.Destinations.Count();
            ViewBag.GuideCount = context.Guides.Count();
            ViewBag.CustomerCount = "285";

            return View();
        }
    }
}
