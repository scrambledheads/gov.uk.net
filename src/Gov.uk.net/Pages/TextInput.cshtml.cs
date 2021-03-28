using Gov.Uk.Net.Library.Models;
using Gov.Uk.Net.Library.Models.Patterns;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Gov.uk.net.Pages
{
    public class TextInputModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<GovUkInputPattern> GovUkInputPatterns;

        public TextInputModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            GovUkInputPatterns = new List<GovUkInputPattern> 
            {
                new GovUkInputPattern
                {
                    Label = new Label
                    {
                        Text = "What is the name of the event?",
                        Classes = new List<string>
                        {
                            "govuk-label--l"
                        },
                        IsPageHeading = true
                    },
                    Id = "event-name",
                    Name = "event-name"
                }
            };
        }
        public void OnGet()
        {

        }
    }
}