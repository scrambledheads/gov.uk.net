﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Threading.Tasks;

namespace Gov.Uk.Net.Library.Components
{
    [HtmlTargetElement("a")]
    public class GovUkBackLinkComponent : TagHelperComponent
    {
        public override int Order => 1;

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (string.Equals(context.TagName, "a", StringComparison.OrdinalIgnoreCase) && output.Attributes.ContainsName("backlink"))
            {
                output.Attributes.Remove(new TagHelperAttribute("backlink"));
                output.Attributes.Add("class", "govuk-back-link");
            }
        }
    }
}
