using Gov.Uk.Net.Library.Models.Patterns;
using Microsoft.AspNetCore.Mvc;

namespace Gov.Uk.Net.Library.Patterns
{
    public class GovUkTextInput : ViewComponent
    {
        public IViewComponentResult Invoke(GovUkTextInputPattern govUkTextInputPattern)
        {
            return View(govUkTextInputPattern);
        }
    }
}
