namespace RentOdevProje.CQRS.Commands.CarCommands
{
    public class CreateCarCommand
    { //entity katmanına gidip neyi ekleme istiyorsak onları alıcaz 
        public string Name { get; set; }
        public string Date { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
        public bool Status { get; set; }
    }
}
