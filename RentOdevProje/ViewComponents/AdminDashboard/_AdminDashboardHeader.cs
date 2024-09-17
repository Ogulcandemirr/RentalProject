using Microsoft.AspNetCore.Mvc;

namespace RentOdevProje.ViewComponents.AdminDashboard
{
    public class _AdminDashboardHeader:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
