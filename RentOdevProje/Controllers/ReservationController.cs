using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RentOdevProje.Controllers
{
    [AllowAnonymous]
    public class ReservationController : Controller
    {
        Context db = new Context();

        private readonly IReservationService _reservationService;
        private readonly ICarService _carService;

        public ReservationController(IReservationService reservationService, ICarService carService)
        {
            _reservationService = reservationService;
            _carService = carService;
        }

        public IActionResult Index()
        {
            var values = _carService.TGetList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddReservation(Customer cus)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Customer cus)
        {
            db.Customers.Add(cus);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
