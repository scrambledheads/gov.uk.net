using Gov.Uk.Net.Library.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using static Gov.Uk.Net.Library.Enums.HeaderEnums;

namespace Gov.Uk.Net.Library.Components
{
    public class GovUkAccordion : TagHelper
    {
        [HtmlAttributeName("id")]
        public string Id { get; set; }

        [HtmlAttributeName("heading-type")]
        public HeadingLevel? HeadingLevel { get; set; }

        [HtmlAttributeName("classes")]
        public List<string> Classes { get; set; }

        [HtmlAttributeName("attributes")]
        public List<Tuple<string, string>> Attributes { get; set; }

        [HtmlAttributeName("items")]
        public List<AccordionItem> Items { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (string.IsNullOrWhiteSpace(Id))
            {
                throw new Exception($"{nameof(Id)} cannot be blank");
            }

            if (Items is null || Items.Count < 1)
            {
                throw new Exception($"There must be at least one item in {nameof(Items)}");
            }

            // Default value is H2 as per component spec - https://design-system.service.gov.uk/components/accordion/
            if (!HeadingLevel.HasValue)
            {
                HeadingLevel = Enums.HeaderEnums.HeadingLevel.h2;
            }

            //var tagContent = await output.GetChildContentAsync();

            output.TagName = "div";
            output.Attributes.Add("class", "govuk-accordion");
            output.Attributes.Add("data-module", "govuk-accordion");

            if (!string.IsNullOrEmpty(Id))
            {
                output.Attributes.Add("id", Id);
            }

            var i = 1;
            foreach (var item in Items)
            {
                var headingInner = new TagBuilder("span");
                    headingInner.AddCssClass("govuk-accordion__section-button");
                    headingInner.Attributes.Add("id", $"{Id}-heading-{i}");
                if (item.HeadingHTML is not null)
                {
                    headingInner.InnerHtml.AppendHtml(item.HeadingHTML);
                }
                else if (item.HeadingText is not null)
                {
                    headingInner.InnerHtml.Append(item.HeadingText);
                }

                var heading = new TagBuilder(HeadingLevel.ToString());
                    heading.AddCssClass("govuk-accordion__section-heading");
                    heading.InnerHtml.AppendHtml(headingInner);

                var header = new TagBuilder("div");
                    header.AddCssClass("govuk-accordion__section-header");
                    header.InnerHtml.AppendHtml(heading);

                var container = new TagBuilder("div");
                    container.AddCssClass("govuk-accordion__section");
                    container.InnerHtml.AppendHtml(header);
                if (item.Expanded)
                {
                    container.AddCssClass("govuk-accordion__section--expanded");
                }

                if (item.SummaryHTML is not null || item.SummaryText is not null)
                {
                    var summary = new TagBuilder("div");
                        summary.AddCssClass("govuk-accordion__section-summary");
                        summary.AddCssClass("govuk-body");
                        summary.Attributes.Add("id", $"{Id}-summary-{i}");

                    if (item.SummaryHTML is not null)
                    {
                        summary.InnerHtml.AppendHtml(item.SummaryHTML);
                    }
                    else if (item.SummaryText is not null)
                    {
                        summary.InnerHtml.Append(item.SummaryText);
                    }

                    header.InnerHtml.AppendHtml(summary);
                }

                var content = new TagBuilder("div");
                    content.AddCssClass("govuk-accordion__section-content");
                    content.Attributes.Add("id", $"{Id}-content-{i}");
                    content.Attributes.Add("aria-labelledby", $"{Id}-heading-{i}");
                if (item.ContentHTML is not null)
                {
                    content.InnerHtml.AppendHtml(item.ContentHTML);
                }
                else if (item.ContentText is not null)
                {
                    content.InnerHtml.Append(item.ContentText);
                }
                container.InnerHtml.AppendHtml(content);

                output.Content.AppendHtml(container);
                i++;
            } 
        }
    }
}
