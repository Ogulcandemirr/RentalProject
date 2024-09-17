using Microsoft.AspNetCore.Mvc;

namespace RentOdevProje.Areas.Member.Controllers
{
	public class MessageController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
