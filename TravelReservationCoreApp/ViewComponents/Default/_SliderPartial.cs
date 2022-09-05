using Microsoft.AspNetCore.Mvc;

namespace TravelReservationCoreApp.Views.Shared.Components._SliderPartial
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View(); 
        }
    }
}
