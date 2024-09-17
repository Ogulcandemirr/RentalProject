using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System.Threading.Tasks;

namespace RentOdevProje.Controllers
{
    [AllowAnonymous]
    public class NewsLetterController : Controller
    {
        private readonly Context _context;

        public NewsLetterController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Subscribe()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Subscribe(NewsLetter newsLetter)
        {
            if (ModelState.IsValid)
            {
                _context.NewsLettes.Add(newsLetter);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index"); 
            }
            return View(newsLetter);
        }
    }
}
