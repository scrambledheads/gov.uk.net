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
        public List<GovUkTextInputPattern> GovUkInputPatterns;

        public TextInputModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            GovUkInputPatterns = new List<GovUkTextInputPattern> 
            {
                new GovUkTextInputPattern
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
                new GovUkTextInputPattern
                {
                    Label = new Label
                    {
                        Text = "What is the name of the event?"
                    },
                    Id = "event-name2",
                    Name = "event-name2"
                },
                new GovUkTextInputPattern
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
                new GovUkTextInputPattern
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
                new GovUkTextInputPattern
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
                new GovUkTextInputPattern
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
                new GovUkTextInputPattern
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
                },
                new GovUkTextInputPattern
                {
                    Label = new Label
                    {
                        Text = "Full width"
                    },
                    Classes = new List<string>
                    {
                        "govuk-!-width-full"
                    },
                    Id = "full",
                    Name = "full"
                },
                new GovUkTextInputPattern
                {
                    Label = new Label
                    {
                        Text = "Three-quarters width"
                    },
                    Classes = new List<string>
                    {
                        "govuk-!-width-three-quarters"
                    },
                    Id = "three-quarters",
                    Name = "three-quarters"
                },
                new GovUkTextInputPattern
                {
                    Label = new Label
                    {
                        Text = "Two-thirds width"
                    },
                    Classes = new List<string>
                    {
                        "govuk-!-width-two-thirds"
                    },
                    Id = "two-thirds",
                    Name = "two-thirds"
                },
                new GovUkTextInputPattern
                {
                    Label = new Label
                    {
                        Text = "Two-thirds width"
                    },
                    Classes = new List<string>
                    {
                        "govuk-!-width-two-thirds"
                    },
                    Id = "two-thirds",
                    Name = "two-thirds"
                },
                new GovUkTextInputPattern
                {
                    Label = new Label
                    {
                        Text = "One-half width"
                    },
                    Classes = new List<string>
                    {
                        "govuk-!-width-one-half"
                    },
                    Id = "one-half",
                    Name = "one-half"
                },
                new GovUkTextInputPattern
                {
                    Label = new Label
                    {
                        Text = "One-third width"
                    },
                    Classes = new List<string>
                    {
                        "govuk-!-width-one-third"
                    },
                    Id = "one-third",
                    Name = "one-third"
                },
                new GovUkTextInputPattern
                {
                    Label = new Label
                    {
                        Text = "One-quarter width"
                    },
                    Classes = new List<string>
                    {
                        "govuk-!-width-one-quarter"
                    },
                    Id = "one-quarter",
                    Name = "one-quarter"
                },
                new GovUkTextInputPattern
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
                    Hint = new Hint
                    {
                        Text = "The name you’ll use on promotional material."
                    },
                    Id = "event-name3",
                    Name = "event-name3"
                },
                new GovUkTextInputPattern
                {
                    Label = new Label
                    {
                        Text = "What is your account number?",
                        Classes = new List<string>
                        {
                            "govuk-label--l"
                        },
                        IsPageHeading = true
                    },
                    Classes = new List<string>
                    {
                        "govuk-input--width-10"
                    },
                    Hint = new Hint
                    {
                        Text = "Must be between 6 and 8 digits long"
                    },
                    Id = "account-number",
                    Name = "account-number",
                    InputMode = "numeric",
                    Pattern = "[0-9*]",
                    SpellCheck = false,
                    DescribedBy = "account-number"
                },
                new GovUkTextInputPattern
                {
                    Id = "cost-per-item",
                    Name = "cost-per-item",
                    Label = new Label
                    {
                        Text = "What is the cost per item, in pounds?",
                        Classes = new List<string>
                        {
                            "govuk-label--l"
                        },
                        IsPageHeading = true
                    },
                    Prefix = new Prefix
                    {
                        Text = "£"
                    },
                    Suffix = new Suffix
                    {
                        Text = "per item"
                    },
                    Classes = new List<string>
                    {
                        "govuk-input--width-5"
                    },
                    SpellCheck = false
                },
                new GovUkTextInputPattern
                {
                    Id = "cost",
                    Name = "cost",
                    Label = new Label
                    {
                        Text = "What is the cost in pounds?",
                        Classes = new List<string>
                        {
                            "govuk-label--l"
                        },
                        IsPageHeading = true
                    },
                    Prefix = new Prefix
                    {
                        Text = "£"
                    },
                    Classes = new List<string>
                    {
                        "govuk-input--width-5"
                    },
                    SpellCheck = false
                },
                new GovUkTextInputPattern
                {
                    Id = "weight",
                    Name = "weight",
                    Label = new Label
                    {
                        Text = "What is the weight in kilograms?",
                        Classes = new List<string>
                        {
                            "govuk-label--l"
                        },
                        IsPageHeading = true
                    },
                    Prefix = new Prefix
                    {
                        Text = "kg"
                    },
                    Suffix = new Suffix
                    {
                        Text = "per item"
                    },
                    Classes = new List<string>
                    {
                        "govuk-input--width-5"
                    },
                    SpellCheck = false
                },
                new GovUkTextInputPattern
                {
                    Id = "postcode",
                    Name = "postcode",
                    Label = new Label
                    {
                        Text = "Postcode"
                    },
                    Classes = new List<string>
                    {
                        "govuk-input--width-10"
                    },
                    AutoComplete = "postal-code"
                },
                new GovUkTextInputPattern
                {
                    Id = "event-name",
                    Name = "event-name",
                    Label = new Label
                    {
                        Text = "What is the name of the event?",
                        Classes = new List<string>
                        {
                            "govuk-label--l"
                        },
                        IsPageHeading = true
                    },
                    Classes = new List<string>
                    {
                        "govuk-input--width-10"
                    },
                    Hint = new Hint
                    {
                        Text = "The name you’ll use on promotional material."
                    },
                    ErrorMessage = new ErrorMessage
                    {
                        Text = "Enter an event name"
                    }
                },
                new GovUkTextInputPattern
                {
                    Id = "cost-per-item-error",
                    Name = "cost-per-item-error",
                    Label = new Label
                    {
                        Text = "What is the cost per item, in pounds?",
                        Classes = new List<string>
                        {
                            "govuk-label--l"
                        },
                        IsPageHeading = true
                    },
                    Prefix = new Prefix
                    {
                        Text = "£"
                    },
                    Suffix = new Suffix
                    {
                        Text = "per item"
                    },
                    Classes = new List<string>
                    {
                        "govuk-input--width-5"
                    },
                    ErrorMessage = new ErrorMessage
                    {
                        Text = "Enter a cost per item, in pounds"
                    },
                    SpellCheck = false
                }
            };
        }
        public void OnGet()
        {

        }
    }
}