using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using RentOdevProje.CQRS.Commands.CarCommands;

namespace RentOdevProje.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly Context _context;

        public CreateCarCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateCarCommand command)
        {
            _context.Cars.Add(new Car
            {
                Name= command.Name,
                Price= command.Price,
                Date= command.Date,
                Capacity= command.Capacity,
                Status= true
            });
            _context.SaveChanges();   
        }              
    }
}
