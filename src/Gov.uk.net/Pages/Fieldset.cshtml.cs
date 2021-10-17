using Gov.Uk.Net.Library.Helpers;
using Gov.Uk.Net.Library.Models;
using Gov.Uk.Net.Library.Models.Patterns;
using Gov.Uk.Net.Library.Patterns;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

using Label = Gov.Uk.Net.Library.Models.Label;

namespace Gov.uk.net.Pages
{
    public class FieldsetsModel : PageModel
    {
        private readonly ILogger<CheckBoxesModel> _logger;
        public readonly List<GovUkFieldsetPattern> _fieldsets;
        private readonly IRenderViewComponentService _renderViewComponentService;

        public FieldsetsModel(ILogger<CheckBoxesModel> logger, IRenderViewComponentService viewComponentRenderService)
        {
            _logger = logger;
            _fieldsets = new List<GovUkFieldsetPattern>();
            _renderViewComponentService = viewComponentRenderService;
        }
        public async Task OnGetAsync()
        {
            await Initialize();
        }

        private async Task Initialize()
        {
            var input1 = new GovUkTextInputPattern()
            {
                Label = new Label
                {
                    Html = new HtmlString(@"Building and street <span class=""govuk-visually-hidden"">line 1 of 2</span>")
                },
                Id = "address-line-1",
                Name = "address-line-1",
                AutoComplete = "address-line1"
            };
            var input1String = await _renderViewComponentService.RenderViewComponentAsStringAsync<GovUkTextInput>(input1);

            var input2 = new GovUkTextInputPattern()
            {
                Label = new Label
                {
                    Html = new HtmlString(@"<span class=""govuk-visually-hidden"">building and street line 2 of 2</span>")
                },
                Id = "address-line-2",
                Name = "address-line-2",
                AutoComplete = "address-line2"
            };
            var input2String = await _renderViewComponentService.RenderViewComponentAsStringAsync<GovUkTextInput>(input2);

            var input3 = new GovUkTextInputPattern()
            {
                Label = new Label
                {
                    Text = "Town or city"
                },
                Classes = new List<string>()
                {
                    "govuk-!-width-two-thirds"
                },
                Id = "address-town",
                Name = "address-town",
                AutoComplete = "address-level2"
            };
            var input3String = await _renderViewComponentService.RenderViewComponentAsStringAsync<GovUkTextInput>(input3);

            var input4 = new GovUkTextInputPattern()
            {
                Label = new Label
                {
                    Text = "County"
                },
                Classes = new List<string>()
                {
                    "govuk-!-width-two-thirds"
                },
                Id = "address-county",
                Name = "address-county"
            };
            var input4String = await _renderViewComponentService.RenderViewComponentAsStringAsync<GovUkTextInput>(input4);

            var input5 = new GovUkTextInputPattern()
            {
                Label = new Label
                {
                    Text = "Postcode"
                },
                Classes = new List<string>()
                {
                    "govuk-input--width-10"
                },
                Id = "address-postcode",
                Name = "address-postcode",
                AutoComplete = "postal-code"
            };
            var input5String = await _renderViewComponentService.RenderViewComponentAsStringAsync<GovUkTextInput>(input5);

            var fieldset1 = new GovUkFieldsetPattern
            {
                HTMLContent = new HtmlString($"{input1String}\n{input2String}\n{input3String}\n{input4String}\n{input5String}"),
                Legend = new Legend("What is your address?", new List<string> { "govuk-fieldset__legend--l" }, isPageHeading: true)
            };
            var fieldset2 = new GovUkFieldsetPattern
            {

                Legend = new Legend("legend as page heading", new List<string> { "govuk-fieldset__legend--l" }, isPageHeading: true)
            };

            _fieldsets.Add(fieldset1);
            _fieldsets.Add(fieldset2);
        }

    }
}
