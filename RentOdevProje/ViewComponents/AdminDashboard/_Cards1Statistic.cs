using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace RentOdevProje.ViewComponents.AdminDashboard
{
    public class _Cards1Statistic:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Cars.Count();
            ViewBag.v2 = c.Users.Count();
            return View();
        }
    }
}
