namespace RentOdevProje.CQRS.Queries.CarQueries
{
    public class GetCarByIDQuery
    {
        public GetCarByIDQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }

    }
}
