using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Gov.uk.net.Pages
{
    public class BackLinkModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public BackLinkModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {

        }
    }
}
