using Gov.Uk.Net.Library.Models;
using Gov.Uk.Net.Library.Models.Patterns;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Gov.uk.net.Pages
{
    public class CharacterCountModel : PageModel
    {
        private readonly ILogger<CharacterCountModel> _logger;
        public List<GovUkCharacterCountPattern> CharacterCounts { get; }

        public CharacterCountModel(ILogger<CharacterCountModel> logger)
        {
            _logger = logger;

            CharacterCounts = new List<GovUkCharacterCountPattern>
            {
                new GovUkCharacterCountPattern
                {
                    Name = "with-hint",
                    Id = "with-hint",
                    MaxLength = 200,
                    Label = new Label
                    {
                        Text = "Can you provide more detail?",
                        Classes = new List<string>
                    {
                        "govuk-label--l"
                    },
                        IsPageHeading = true
                    },
                    Hint = new Hint
                    {
                        Text = "Do not include personal or financial information like your National Insurance number or credit card details."
                    }
                    //,ErrorMessage = ErrorMessage
                    //,CountMessage = new CountMessage
                    //{
                    //    Classes = new List<string>
                    //    {
                    //        "TestClass"
                    //    }
                    //}
                }
            };
        }

        public void OnGet()
        {

        }
    }
}
