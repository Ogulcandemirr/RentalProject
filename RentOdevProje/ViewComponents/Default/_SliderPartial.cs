﻿using Microsoft.AspNetCore.Mvc;

namespace RentOdevProje.ViewComponents.Default
{
    public class _SliderPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
