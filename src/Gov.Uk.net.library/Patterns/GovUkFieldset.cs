using Gov.Uk.Net.Library.Models.Patterns;
using Microsoft.AspNetCore.Mvc;

namespace Gov.Uk.Net.Library.Patterns
{
    public class GovUkFieldset : ViewComponent
    {
        public IViewComponentResult Invoke(GovUkFieldsetPattern govUkFieldsetPattern)
        {
            return View(govUkFieldsetPattern);
        }
    }
}
