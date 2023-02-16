using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TravelReservationCoreApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDAL());
        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult AddDestination(Destination destination)
        {
            destination.Description = "true";
            destinationManager.TAdd(destination);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteDestination(int id)
        {
            var destination = destinationManager.TGetById(id);
            destinationManager.TDelete(destination);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var destination = destinationManager.TGetById(id);
            return View(destination);
        }

        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {

            destinationManager.TUpdate(destination);
            return RedirectToAction("Index");
        }
    }
}
