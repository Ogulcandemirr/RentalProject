﻿using DataAccessLayer.Concrete;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RentOdevProje.CQRS.Queries.CarQueries;
using RentOdevProje.CQRS.Queries.GuideQueries;
using RentOdevProje.CQRS.Results.GuideResult;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RentOdevProje.CQRS.Handlers.GuideHandlers
{
    public class GetAllGuideQueryHandler : IRequestHandler<GetAllGuideQuery, List<GetAllGuideQueryResult>>
    {
        private readonly Context _context;

        public GetAllGuideQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllGuideQueryResult>> Handle(GetAllGuideQuery request, CancellationToken cancellationToken)
        {
            return await _context.Guides.Select(x => new GetAllGuideQueryResult { GuideId = x.GuideId, Description = x.Description, Image = x.Image, Name = x.Name }).AsNoTracking().ToListAsync();
        }
    }
}
