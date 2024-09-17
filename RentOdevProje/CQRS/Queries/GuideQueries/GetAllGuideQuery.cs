using DocumentFormat.OpenXml.Office2010.ExcelAc;
using MediatR;
using RentOdevProje.CQRS.Results.GuideResult;
using System.Collections.Generic;

namespace RentOdevProje.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery:IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
