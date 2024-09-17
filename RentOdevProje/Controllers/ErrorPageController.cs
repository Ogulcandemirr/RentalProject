using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace RentOdevProje.Controllers
{
	public class ErrorPageController : Controller
	{
		public IActionResult Error404(int code)
		{
			return View();
		}
	}
}
