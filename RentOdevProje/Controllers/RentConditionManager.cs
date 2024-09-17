using BusinessLayer.Abstract;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RentOdevProje.Controllers
{
    [AllowAnonymous]

    public class RentConditionManager : Controller
    {
        private readonly IRentConditionService _rentConditionService;

        public RentConditionManager(IRentConditionService rentConditionService)
        {
            _rentConditionService = rentConditionService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
