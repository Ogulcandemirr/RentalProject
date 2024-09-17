﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RentOdevProje.Controllers
{
    [AllowAnonymous]
    public class GuideController : Controller
    {
        GuideManager guideManager = new GuideManager(new EfGuideDal());
        public IActionResult Index()
        {
            var values = guideManager.TGetList();
            return View(values);
        }
    }
}
