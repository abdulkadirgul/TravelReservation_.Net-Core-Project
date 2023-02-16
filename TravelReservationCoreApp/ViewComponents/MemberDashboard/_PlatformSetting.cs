using Microsoft.AspNetCore.Mvc;

namespace TravelReservationCoreApp.ViewComponents.MemberDashboard
{
    public class _PlatformSetting:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            return View();
        }
    }
}
