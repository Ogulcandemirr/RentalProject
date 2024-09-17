using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RentOdevProje.Controllers
{
    [AllowAnonymous]
    public class CompanyAboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public IActionResult Index()
        {
            return View();
        }
    }
}
