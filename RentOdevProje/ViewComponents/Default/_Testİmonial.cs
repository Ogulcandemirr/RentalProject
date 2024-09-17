using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;

namespace RentOdevProje.ViewComponents.Default
{
    public class _Testİmonial : ViewComponent
    {
        TestİmonialManager testimonialManager = new TestİmonialManager(new EfTestİmonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }
    }
}
