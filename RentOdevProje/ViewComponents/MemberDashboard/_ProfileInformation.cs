﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace RentOdevProje.ViewComponents.MemberDashboard
{
    public class _ProfileInformation :ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _ProfileInformation(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task< IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.memberName = values.UserName + " " + values.SurName;
            ViewBag.memberPhone = values.PhoneNumber;
            ViewBag.memberMail = values.Email;
            return View();
        }
    }
}

