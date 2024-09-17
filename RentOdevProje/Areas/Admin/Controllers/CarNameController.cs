using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentOdevProje.Models;
using System.Collections.Generic;

namespace RentOdevProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CarNameController : Controller
    {
        private readonly ICarService _carService;

        public CarNameController(ICarService carService)
        {
            _carService = carService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CarNameList()
        {
            var jsonCar = JsonConvert.SerializeObject(_carService.TGetList());
            return Json(jsonCar);
        }

        [HttpPost]
        public IActionResult AddNameCar(Car car)
        {
            _carService.Tadd(car);
           var values =JsonConvert.SerializeObject(car);
            return Json(values);
        }

        public IActionResult GetById(int CarId)
        {
            var values = _carService.TGetById(CarId);
            var jsonValues= JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }

        public IActionResult DeleteCarName(int id)
        {
            var values=_carService.TGetById(id);
            _carService.TDelete(values);
            return NoContent();
        }
        public IActionResult UpdateCarName(Car car)
        {
            var values= _carService.TGetById(car.CarId);
            _carService.TUpdate(car);
            var v = JsonConvert.SerializeObject(car);
            return Json(v);
        }

        //public static List<CarNameClass> CarNames = new List<CarNameClass>
        //{
        //	new CarNameClass
        //	{
        //		CarNameId = 1,
        //		CarName = "E200",
        //		CarBrand = "Mercedes"
        //	},
        //	new CarNameClass
        //	{
        //		CarNameId= 2,
        //		CarName="5.20",
        //		CarBrand="Bmw"
        //	},
        //	new CarNameClass
        //	{
        //		CarNameId=3,
        //		CarName="A4",
        //		CarBrand="Audi"
        //	}
        //};

    }
}
