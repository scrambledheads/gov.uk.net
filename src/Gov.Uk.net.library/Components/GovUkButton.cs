using Gov.Uk.Net.Library.Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using static Gov.Uk.Net.Library.Enums.HTMLEnums;

namespace Gov.Uk.Net.Library
{
    public class GovUkButton : TagHelper
    {
        [HtmlAttributeName("element")]
        public ButtonType Element { get; set; }

        [HtmlAttributeName("text")]
        public string Text { get; set; }

        [HtmlAttributeName("html")]
        public IHtmlContent Html { get; set; }

        [HtmlAttributeName("name")]
        public string Name { get; set; }

        [HtmlAttributeName("type")]
        public string Type { get; set; }

        [HtmlAttributeName("value")]
        public string Value { get; set; }

        [HtmlAttributeName("disabled")]
        public bool Disabled { get; set; }

        [HtmlAttributeName("href")]
        public string Href { get; set; }

        [HtmlAttributeName("classes")]
        public List<string> Classes { get; set; }

        [HtmlAttributeName("attributes")]
        public List<Tuple<string, string>> Attributes { get; set; }

        [HtmlAttributeName("preventDoubleClick")]
        public bool PreventDoubleClick { get; set; }

        [HtmlAttributeName("isStartButton")]
        public bool IsStartButton { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            
        }
    }
}
