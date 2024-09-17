using DataAccessLayer.Concrete;
using MediatR;
using RentOdevProje.CQRS.Queries.GuideQueries;
using RentOdevProje.CQRS.Results.GuideResult;
using System.Threading;
using System.Threading.Tasks;

namespace RentOdevProje.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIdQueryHandler : IRequestHandler<GetGuideByIdQuery, GetGuideByIdQueryResult>   // request ve cevap istiyor 2 parametre
    {
        private readonly Context _context;

        public GetGuideByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIdQueryResult> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var values=await _context.Guides.FindAsync(request.Id);
            return new GetGuideByIdQueryResult
            {
                GuideId = request.Id,
                Description = values.Description,
                Name = values.Name
            };
        }
    }
}
