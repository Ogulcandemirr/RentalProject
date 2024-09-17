using DataAccessLayer.Concrete;
using RentOdevProje.CQRS.Commands.CarCommands;

namespace RentOdevProje.CQRS.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler
    {
        private readonly Context _context;

        public UpdateCarCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateCarCommand command)
        {
            var values = _context.Cars.Find(command.CarId);
            values.Name=command.Name;
            values.Date=command.Date;
            values.Price=command.Price;
            _context.SaveChanges();
        }
    }
}
