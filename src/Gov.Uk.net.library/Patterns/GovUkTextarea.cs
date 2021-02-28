using Gov.Uk.Net.Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gov.Uk.Net.Library.Patterns
{
    public class GovUkTextarea : ViewComponent
    {
        public IViewComponentResult Invoke(Textarea textarea)
        {
            return View(textarea);
        }
    }
}
