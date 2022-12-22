using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelReservationCoreApp.ViewComponents.Default
{
    public class _Feature: ViewComponent
    {

        FeatureManager featureManager = new FeatureManager(new EfFeatureDAL());
        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetList();

            return View(values);
        }

    }
}
