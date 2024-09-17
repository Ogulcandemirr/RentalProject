using DataAccessLayer.Concrete;
using RentOdevProje.CQRS.Queries.CarQueries;
using RentOdevProje.CQRS.Results.CarResult;

namespace RentOdevProje.CQRS.Handlers.CarHandlers
{
    public class GetCarByIDQueryHandler
    {
        private readonly Context _context;

        public GetCarByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetCarByIDQueryResult Handle(GetCarByIDQuery query)
        {
            var values = _context.Cars.Find(query.Id);
            return new GetCarByIDQueryResult
            {
                CarId = values.CarId,
                Name = values.Name,
                Date = values.Date,
                Price = values.Price
            };
        }
    }
}
