using Gov.Uk.Net.Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gov.Uk.Net.Library.Patterns
{
    public class GovUkLabel : ViewComponent
    {
        public IViewComponentResult Invoke(Label label)
        {
            return View(label);
        }
    }
}
