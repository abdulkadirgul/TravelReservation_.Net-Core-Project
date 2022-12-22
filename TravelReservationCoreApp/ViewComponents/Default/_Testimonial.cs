using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelReservationCoreApp.ViewComponents.Default
{
    public class _Testimonial: ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager( new EfTestimonialDAL());
        public IViewComponentResult Invoke()
        {
            var value = testimonialManager.TGetList();
            return View(value);
        }
    }
}
