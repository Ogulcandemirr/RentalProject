﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RentOdevProje.Areas.Member.Controllers
{
	public class CommentController : Controller
	{
		[Area("Member")]
		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}
	}
}
