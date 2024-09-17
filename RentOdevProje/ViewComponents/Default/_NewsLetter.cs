using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;

namespace RentOdevProje.ViewComponents.Default
{
    public class _NewsLetter:ViewComponent
    {
        NewstLetterManager newstLetterManager = new NewstLetterManager(new EfNewsLetterDal());
        public IViewComponentResult Invoke()
        {
            var values = newstLetterManager.TGetList();
            return View(values);
        }
    }
}
