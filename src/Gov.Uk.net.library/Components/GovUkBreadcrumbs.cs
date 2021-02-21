using Gov.Uk.Net.Library.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using static Gov.Uk.Net.Library.Enums.HeaderEnums;

namespace Gov.Uk.Net.Library
{
    public class GovUkBreadcrumbs : TagHelper
    {
        [HtmlAttributeName("items")]
        public List<BreadcrumbItem> Items { get; set; }

        [HtmlAttributeName("classes")]
        public List<string> Classes { get; set; }

        [HtmlAttributeName("collapseOnMobile")]
        public bool CollapseOnMobile { get; set; }

        [HtmlAttributeName("attributes")]
        public List<Tuple<string, string>> Attributes { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var breadcrumbList = new TagBuilder("ol");
            breadcrumbList.AddCssClass("govuk-breadcrumbs__list");

            output.TagName = "div";
            output.AddClass("govuk-breadcrumbs", HtmlEncoder.Default);

            if (Classes != null && Classes.Count > 0)
            {
                foreach (var @class in Classes)
                {
                    output.AddClass(@class, HtmlEncoder.Default);
                }
            }

            if (CollapseOnMobile)
            {
                output.AddClass("govuk-breadcrumbs--collapse-on-mobile", HtmlEncoder.Default);
            }

            if (Items != null && Items.Count > 0)
            {
                foreach (var item in Items)
                {
                    var anchor = new TagBuilder("a");
                    if (!string.IsNullOrWhiteSpace(item.Href))
                    {
                        anchor.AddCssClass("govuk-breadcrumbs__link");
                        anchor.Attributes.Add("href", item.Href);
                        
                        if (item.Attributes != null && item.Attributes.Count > 0)
                        {
                            foreach (var attribute in item.Attributes)
                            {
                                anchor.Attributes.Add(attribute.Item1, attribute.Item2);
                            }
                        }
                    }
                    else
                    {
                        anchor.AddCssClass("govuk-breadcrumbs__list-item");
                        anchor.Attributes.Add("aria-current", "page");
                    }
                    if (item.HTML != null)
                    {
                        anchor.InnerHtml.AppendHtml(item.HTML);
                    }
                    else
                    {
                        anchor.InnerHtml.Append(item.Text);
                    }
                    var listItem = new TagBuilder("li");
                        listItem.AddCssClass("govuk-breadcrumbs__list-item");
                        listItem.InnerHtml.AppendHtml(anchor);

                    breadcrumbList.InnerHtml.AppendHtml(listItem);
                }
            }

            output.Content.AppendHtml(breadcrumbList);
        }
    }
}
