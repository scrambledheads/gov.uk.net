using Gov.Uk.Net.Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gov.Uk.Net.Library.Patterns
{
    public class GovUkErrorMessage : ViewComponent
    {
        public IViewComponentResult Invoke(ErrorMessage errorMessage)
        {
            return View(errorMessage);
        }
    }
}
