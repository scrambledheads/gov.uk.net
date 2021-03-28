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
                },
                new GovUkInputPattern
                {
                    Label = new Label
                    {
                        Text = "What is the name of the event?"
                    },
                    Id = "event-name2",
                    Name = "event-name2"
                },
                new GovUkInputPattern
                {
                    Label = new Label
                    {
                        Text = "20 character width"
                    },
                    Classes = new List<string>
                    {
                        "govuk-input--width-20"
                    },
                    Id = "width-20",
                    Name = "width-20"
                },
                new GovUkInputPattern
                {
                    Label = new Label
                    {
                        Text = "10 character width"
                    },
                    Classes = new List<string>
                    {
                        "govuk-input--width-10"
                    },
                    Id = "width-10",
                    Name = "width-10"
                },
                new GovUkInputPattern
                {
                    Label = new Label
                    {
                        Text = "5 character width"
                    },
                    Classes = new List<string>
                    {
                        "govuk-input--width-5"
                    },
                    Id = "width-5",
                    Name = "width-5"
                },
                new GovUkInputPattern
                {
                    Label = new Label
                    {
                        Text = "3 character width",
                    },
                    Classes = new List<string>
                    {
                        "govuk-input--width-3"
                    },
                    Id = "width-3",
                    Name = "width-3"
                },
                new GovUkInputPattern
                {
                    Label = new Label
                    {
                        Text = "2 character width"
                    },
                    Classes = new List<string>
                    {
                        "govuk-input--width-2"
                    },
                    Id = "width-2",
                    Name = "width-2"
                }
            };
        }
        public void OnGet()
        {

        }
    }
}