using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace RentOdevProje.ViewComponents.Default
{
    public class _Statistics:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = "+175";                      //c.Cars.Count();
            ViewBag.v2 = "+16785";
            ViewBag.v3 = "+1329";
            ViewBag.v4 = "+10";
            return View();
        }
    }
}
