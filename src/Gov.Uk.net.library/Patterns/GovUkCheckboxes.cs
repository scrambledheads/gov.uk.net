﻿using Gov.Uk.Net.Library.Models.Patterns;
using Microsoft.AspNetCore.Mvc;

namespace Gov.Uk.Net.Library.Patterns
{
    public class GovUkCheckboxes : ViewComponent
    {
        public IViewComponentResult Invoke(GovUkCheckboxesPattern govUkCheckboxesPattern)
        {
            return View(govUkCheckboxesPattern);
        }
    }
}
