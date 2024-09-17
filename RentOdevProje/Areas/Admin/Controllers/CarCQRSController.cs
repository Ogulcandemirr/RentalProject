using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RentOdevProje.CQRS.Commands.CarCommands;
using RentOdevProje.CQRS.Handlers.CarHandlers;
using RentOdevProje.CQRS.Queries.CarQueries;

namespace RentOdevProje.Areas.Admin.Controllers
{
	[Area("Admin")]
	[AllowAnonymous]
	public class CarCQRSController : Controller
	{
		private readonly GetAllCarQueryHandler _getAllCarQueryHandler;
		private readonly GetCarByIDQueryHandler _getCarByIDQueryHandler;
		private readonly CreateCarCommandHandler _createCarCommandHandler;
		private readonly RemoveCarCommandHandler _removeCarCommandHandler;
		private readonly UpdateCarCommandHandler _updateCarCommandHandler;

		public CarCQRSController(GetAllCarQueryHandler getAllCarQueryHandler, GetCarByIDQueryHandler getCarByIDQueryHandler, CreateCarCommandHandler createCarCommandHandler, RemoveCarCommandHandler removeCarCommandHandler, UpdateCarCommandHandler updateCarCommandHandler)
		{
			_getAllCarQueryHandler = getAllCarQueryHandler;
			_getCarByIDQueryHandler = getCarByIDQueryHandler;
			_createCarCommandHandler = createCarCommandHandler;
			_removeCarCommandHandler = removeCarCommandHandler;
			_updateCarCommandHandler = updateCarCommandHandler;
		}

		public IActionResult Index()
		{
			var values = _getAllCarQueryHandler.Handle();
			return View(values);
		}

		[HttpGet]
		public IActionResult GetCar(int id)
		{
			var values = _getCarByIDQueryHandler.Handle(new GetCarByIDQuery(id));
			return View(values);
		}

        [HttpPost]
        public IActionResult GetCar(UpdateCarCommand command)
        {
            _updateCarCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }

        [HttpGet]
		public IActionResult AddCar()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddCar(CreateCarCommand command)
		{
			_createCarCommandHandler.Handle(command);
			return RedirectToAction("Index");
		}

		public IActionResult DeleteCar(int id)
		{
			_removeCarCommandHandler.Handle(new RemoveCarCommand(id));
			return RedirectToAction("Index");

		}
	}
}


