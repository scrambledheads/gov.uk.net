using Gov.Uk.Net.Library.Models;
using Gov.Uk.Net.Library.Models.Patterns;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Gov.uk.net.Pages
{
    public class CheckBoxesModel : PageModel
    {
        private readonly ILogger<CheckBoxesModel> _logger;
        public GovUkCheckboxesPattern Checkboxes;

        public CheckBoxesModel(ILogger<CheckBoxesModel> logger)
        {
            _logger = logger;
            Checkboxes = new GovUkCheckboxesPattern
            {
                IdPrefix = "waste",
                Name = "waste",
                Fieldset = new Fieldset
                {
                    Legend = new Legend("Which types of waste do you transport?", new List<string> {"govuk-fieldset__legend--l"}, true)
                },
                Hint = new Hint
                {
                    Text = "Select all that apply."
                },
                Items = new List<CheckboxItem>
                {
                    new CheckboxItem
                    {
                        Value = "carcasses",
                        Text = "Waste from animal carcasses"
                    },
                    new CheckboxItem
                    {
                        Value = "mines",
                        Text = "Waste from mines or quarries"
                    },
                    new CheckboxItem
                    {
                        Value = "farm",
                        Text = "Farm or agricultural waste"
                    }
                }
            };


        }

        public void OnGet()
        {

        }
    }
}
