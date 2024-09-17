using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace RentOdevProje.ViewComponents.MemberDashboard
{
	public class _CarOffer:ViewComponent
	{
		private readonly ICarService _carService;

		public _CarOffer(ICarService carService)
		{
			_carService = carService;
		}

		public IViewComponentResult Invoke()
		{
			var values=_carService.TGetLastCarOffer();
			return View(values);
		}
	}
}
