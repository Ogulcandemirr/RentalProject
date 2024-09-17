using DataAccessLayer.Concrete;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.EntityFrameworkCore;
using RentOdevProje.CQRS.Queries.CarQueries;
using RentOdevProje.CQRS.Results.CarResult;
using System.Collections.Generic;
using System.Linq;

namespace RentOdevProje.CQRS.Handlers.CarHandlers
{
    public class GetAllCarQueryHandler
	{
		private readonly Context _context;

		public GetAllCarQueryHandler(Context context)
		{
			_context = context;
		}

		public List<GetAllCarQuerryResult> Handle() 
		{
			var values = _context.Cars.Select(x => new GetAllCarQuerryResult
			{
				id=x.CarId, 
				capacity=x.Capacity,
				name=x.Name,
				date=x.Date,
				price=x.Price
			}).AsNoTracking().ToList();
			return values;
		}
	}
}
