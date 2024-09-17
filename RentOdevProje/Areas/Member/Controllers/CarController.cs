using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RentOdevProje.Areas.Member.Controllers
{
    [AllowAnonymous]
    [Area("Member")]
    public class CarController : Controller
	{
        CarManager carManager = new CarManager(new EfCarDal());
        public IActionResult Index()
		{
            var values = carManager.TGetList();
            return View(values);
		}
	}
}
