using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelReservationCoreApp.ViewComponents.MemberDashboard
{
    public class _GuideList:ViewComponent
    {
        GuideManager guideManager = new GuideManager(new EfGuideDAL());
        public IViewComponentResult Invoke(int id)
        {
            var values = guideManager.TGetList();
            return View(values);
        }
    }
}
