using MediatR;
using RentOdevProje.CQRS.Results.GuideResult;

namespace RentOdevProje.CQRS.Queries.GuideQueries
{
    public class GetGuideByIdQuery:IRequest<GetGuideByIdQueryResult>
    {
        public GetGuideByIdQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
