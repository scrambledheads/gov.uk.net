using Gov.Uk.Net.Library.Models.Patterns;
using Microsoft.AspNetCore.Mvc;

namespace Gov.Uk.Net.Library.Patterns
{
    public class GovUkCharacterCount: ViewComponent
    {
        public IViewComponentResult Invoke(GovUkCharacterCountPattern govUkCharacterCountPattern)
        {
            return View(govUkCharacterCountPattern);
        }
    }
}
