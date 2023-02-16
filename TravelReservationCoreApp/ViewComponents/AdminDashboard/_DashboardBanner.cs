using Microsoft.AspNetCore.Mvc;

namespace TravelReservationCoreApp.ViewComponents.AdminDashboard
{
    public class _DashboardBanner : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            return View();
        }

    }
}
