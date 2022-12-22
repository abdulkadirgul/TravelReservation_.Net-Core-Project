using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelReservationCoreApp.ViewComponents.Default
{
    public class _PopularDestinations : ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDAL());
        public IViewComponentResult Invoke() 
        {
            var values = destinationManager.TGetList();

            return View(values);
        }
    }
}
