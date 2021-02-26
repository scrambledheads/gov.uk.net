using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Gov.uk.net.Pages
{
    public class ButtonModel : PageModel
    {
        private readonly ILogger<ButtonModel> _logger;

        public ButtonModel(ILogger<ButtonModel> logger)
        {
            _logger = logger;


        }

        public void OnGet()
        {

        }
    }
}
