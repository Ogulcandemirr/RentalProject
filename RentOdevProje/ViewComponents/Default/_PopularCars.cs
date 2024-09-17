using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;

namespace RentOdevProje.ViewComponents.Default
{
    public class _PopularCars :ViewComponent
    {
        CarManager carsManager = new CarManager(new EfCarDal());
        public IViewComponentResult Invoke()
        {
            var values = carsManager.TGetList();
            return View(values);
        }
    }
}
