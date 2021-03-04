using Gov.Uk.Net.Library.Models;
using Gov.Uk.Net.Library.Models.Patterns;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
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
                },
                new GovUkCharacterCountPattern
                {
                    Name= "with-hint",
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
                    Hint  = new Hint
                    {
                        Text = "Do not include personal or financial information like your National Insurance number or credit card details."
                    }
                },
                new GovUkCharacterCountPattern
                {
                    Name= "label-as-page-heading",
                    Id = "label-as-page-heading",
                    MaxLength = 200,
                    Label = new Label
                    {
                        Text = "Describe the nature of your event"
                    }
                },
                new GovUkCharacterCountPattern
                {
                    Name= "word-count",
                    Id = "word-count",
                    MaxWords = 150,
                    Label = new Label
                    {
                        Text = "Enter a job description",
                        Classes = new List<string>
                        {
                            "govuk-label--l"
                        },
                        IsPageHeading = true
                    }
                },
                new GovUkCharacterCountPattern
                {
                    Name= "word-count",
                    Id = "word-count",
                    MaxLength = 112,
                    Threshold = 75,
                    Value = "Type another letter into this field after this message to see the threshold feature",
                    Label = new Label
                    {
                        Text = "Can you provide more detail?",
                        Classes = new List<string>
                        {
                            "govuk-label--l"
                        },
                        IsPageHeading = true
                    }
                },
                new GovUkCharacterCountPattern
                {
                    Name= "exceeding",
                    Id = "exceeding-characters",
                    MaxLength = 350,
                    Value = "A content designer works on the end-to-end journey of a service to help users complete their goal and government deliver a policy intent. Their work may involve the creation of, or change to, a transaction, product or single piece of content that stretches across digital and offline channels. They make sure appropriate content is shown to a user in the right place and in the best format.",
                    Label = new Label
                    {
                        Text = "Enter a job description",
                        Classes = new List<string>
                        {
                            "govuk-label--l"
                        },
                        IsPageHeading = true
                    },
                    ErrorMessage = new ErrorMessage
                    {
                        Text = "Job description must be 350 characters or fewer"
                    }
                }
            };
        }

        public void OnGet()
        {

        }
    }
}
