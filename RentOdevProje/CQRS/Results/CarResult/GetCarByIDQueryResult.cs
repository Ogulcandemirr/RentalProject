namespace RentOdevProje.CQRS.Results.CarResult
{
    public class GetCarByIDQueryResult
    {
        public int CarId { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public double Price { get; set; }
    }
}
