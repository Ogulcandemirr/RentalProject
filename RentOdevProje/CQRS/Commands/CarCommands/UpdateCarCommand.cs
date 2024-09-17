namespace RentOdevProje.CQRS.Commands.CarCommands
{
    public class UpdateCarCommand
    {
        public int CarId { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public double Price { get; set; }
    }
}
