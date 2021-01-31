using Gov.Uk.net.library.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Gov.Uk.net.library.Enums.HeaderEnums;

namespace Gov.Uk.net.library.Components.Accordion
{
    public class GovUkAccordion : TagHelper
    {
        [HtmlAttributeName("id")]
        public string Id { get; set; }

        [HtmlAttributeName("heading-type")]
        public HeadingLevel? HeadingLevel { get; set; }

        [HtmlAttributeName("heading")]
        public string Heading { get; set; }

        [HtmlAttributeName("items")]
        public List<AccordionItem> Items { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (string.IsNullOrWhiteSpace(Id))
            {
                throw new Exception($"{nameof(Id)} cannot be blank");
            }

            // Default value is H2 as per component spec - https://design-system.service.gov.uk/components/accordion/
            if (!HeadingLevel.HasValue)
            {
                HeadingLevel = Enums.HeaderEnums.HeadingLevel.h2;
            }

            var tagContent = await output.GetChildContentAsync();
            if (tagContent.IsEmptyOrWhiteSpace)
            {
                throw new Exception($"There must be accordion content");
            }

            output.TagName = "div";
        }
    }
}
