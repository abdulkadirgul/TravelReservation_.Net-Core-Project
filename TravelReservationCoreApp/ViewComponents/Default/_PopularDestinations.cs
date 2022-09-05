using Microsoft.AspNetCore.Mvc;

namespace TravelReservationCoreApp.ViewComponents.Default
{
    public class _PopularDestinations : ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View();
        }
    }
}
