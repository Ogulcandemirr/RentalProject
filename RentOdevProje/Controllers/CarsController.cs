using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RentOdevProje.Areas.Admin.Controllers;
using System.Threading.Tasks;

namespace RentOdevProje.Controllers
{
    [AllowAnonymous]
    public class CarsController : Controller
    {           
        CarManager carManager = new CarManager(new EfCarDal());
        private readonly UserManager<AppUser> _userManager;

        public CarsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = carManager.TGetList();
            return View(values);
        }
        //[HttpGet]
        public async Task<IActionResult> CarsDetails(int id)
        {
            ViewBag.i = id;
            ViewBag.carID = id;
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userID=value.Id;
            var values = carManager.TGetCarWithGuide(id);
            return View(values);
        }
        //[HttpPost]
        //public IActionResult CarsDetails(Car p)
        //{
        //    return View();
        //}

    }
}
