using Gov.Uk.Net.Library.Models.Patterns;
using Microsoft.AspNetCore.Mvc;

namespace Gov.Uk.Net.Library.Patterns
{
    public class GovUkInput : ViewComponent
    {
        public IViewComponentResult Invoke(GovUkInputPattern govUkInputPattern)
        {
            return View(govUkInputPattern);
        }
    }
}
