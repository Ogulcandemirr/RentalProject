using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace RentOdevProje.Areas.Admin.Controllers
{
	[Area("Admin")]
    //[Route("Admin/Car")]

    public class CarController : Controller
	{
		private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        public IActionResult Index()
		{
			var values = _carService.TGetList();
			return View(values);
		}
		[HttpGet]
        public IActionResult AddCar()
		{
			return View();
		}

        [HttpPost]
		public IActionResult AddCar(Car car)
        {
            _carService.Tadd(car);
			return RedirectToAction("Index");
        }

        public IActionResult DeleteCar(int id)
		{
			var values = _carService.TGetById(id);
            _carService.TDelete(values);
			return RedirectToAction("Index");
		}
       	
		[HttpGet]
		public IActionResult UpdateCar(int id)
        {
            var values = _carService.TGetById(id);
			return View(values);
        }

        [HttpPost]
		public IActionResult UpdateCar(Car car)
        {
            _carService.TUpdate(car);
			return RedirectToAction("Index");
        }

        [Route("ChangeToTrue/{id}")]
        public IActionResult ChangeToTrue(int id)
        {
            _carService.TChangeToTrueByCar(id);
            return RedirectToAction("Index","Car", new { area = "Admin" });

        }

        [Route("ChangeToFalse/{id}")]
        public IActionResult ChangeToFalse(int id)
        {
            _carService.TChangeToFalseByCar(id);
            return RedirectToAction("Index", "Car", new { area = "Admin" });


        }

    }
}
//"Car", new { area = "Admin" });