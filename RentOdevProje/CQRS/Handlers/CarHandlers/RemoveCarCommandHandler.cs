using DataAccessLayer.Concrete;
using RentOdevProje.CQRS.Commands.CarCommands;

namespace RentOdevProje.CQRS.Handlers.CarHandlers
{
    public class RemoveCarCommandHandler
    {
        private readonly Context _context;

        public RemoveCarCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveCarCommand command)
        {
            var values = _context.Cars.Find(command.Id);
            _context.Cars.Remove(values);
            _context.SaveChanges();
        }
    }
}
