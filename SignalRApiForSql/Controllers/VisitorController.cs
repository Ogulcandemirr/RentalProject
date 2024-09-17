using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using SignalRApiForSql.DAL;
using SignalRApiForSql.Models;

namespace SignalRApiForSql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        private readonly VisitorService _visitorService;

        public VisitorController(VisitorService visitorService)
        {
            _visitorService = visitorService;
        }
        [HttpGet]
        public IActionResult CreateVisitor()
        {
            Random random = new Random();
            Enumerable.Range(1, 10).ToList().ForEach(x =>
            {
                foreach (ECar item in Enum.GetValues(typeof(ECar)))
                {
                    var newVisitor = new Visitor
                    {
                        Car = item,
                        CarRentCount = random.Next(100, 2000),
                        Date = DateTime.Now.AddDays(x)
                    };
                    _visitorService.SaveVisitor(newVisitor).Wait();
                    System.Threading.Thread.Sleep(1000); // her ekleme işlemini saniyede 1 defa yap
                }
            });
            return Ok("Ziyaretçiler başarılı bir şekilde eklendi");
        }
    }
}
