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
        public List<Tuple<string, string>> Classes { get; set; }

        [HtmlAttributeName("collapseOnMobile")]
        public bool CollapseOnMobile { get; set; }

        [HtmlAttributeName("attributes")]
        public List<Tuple<string, string>> Attributes { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.AddClass("govuk-breadcrumbs", HtmlEncoder.Default);

            if (CollapseOnMobile)
            {
                output.AddClass("govuk-breadcrumbs--collapse-on-mobile", HtmlEncoder.Default);
            }
        }
    }
}
