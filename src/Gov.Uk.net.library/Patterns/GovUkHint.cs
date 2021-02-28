using Gov.Uk.Net.Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gov.Uk.Net.Library.Patterns
{
    public class GovUkHint : ViewComponent
    {
        public IViewComponentResult Invoke(Hint hint)
        {
            return View(hint);
        }
    }
}
