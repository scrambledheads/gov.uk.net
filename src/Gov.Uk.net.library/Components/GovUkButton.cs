using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
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

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var classNames = new List<string>
            {
                "govuk-button"
            };
            
            if (Classes != null && Classes.Count > 0)
            {
                classNames.AddRange(Classes);
            }

            if (Disabled)
            {
                classNames.Add("govuk-button--disabled");
            }

            // Determine type of element to use, if not explicitly set
            if (!string.IsNullOrWhiteSpace(Href))
            {
                Element = ButtonType.a;
            }
            else
            {
                Element = ButtonType.button;
            }

            if (IsStartButton)
            {
                /* The SVG needs 'focusable="false"' so that Internet Explorer does not
                    treat it as an interactive element - without this it will be
                    'focusable' when using the keyboard to navigate. */

                var svg = @"<svg class=""govuk-button__start-icon"" xmlns=""http://www.w3.org/2000/svg"" width=""17.5"" height=""19"" viewBox=""0 0 33 40"" aria-hidden=""true"" focusable=""false"">
                                <path fill=""currentColor"" d=""M0 0h13l20 20-20 20H0l20-20z"" />
                            </svg>";

                classNames.Add("govuk-button--start");

                if (Element.Equals(ButtonType.a) || Element.Equals(ButtonType.button))
                {
                    var tagContent = await output.GetChildContentAsync();
                    tagContent.AppendHtml(svg);
                    output.Content.AppendHtml(tagContent);
                }
            }

            output.TagName = Element.ToString();

            foreach (var className in classNames)
            {
                output.AddClass(className, HtmlEncoder.Default);
            }

            switch (Element)
            {
                case ButtonType.a:
                    output.Attributes.Add("href", Href ?? "#");
                    output.Attributes.Add("role", "button");
                    output.Attributes.Add("draggable", "false");
                    break;
                case ButtonType.button:
                    if (!string.IsNullOrWhiteSpace(Value))
                    {
                        output.Attributes.Add("value", Value);
                    }
                    if (!string.IsNullOrWhiteSpace(Type))
                    {
                        output.Attributes.Add("type", Type);
                    }
                    break;
                case ButtonType.input:
                    if (!string.IsNullOrWhiteSpace(Value))
                    {
                        output.Attributes.Add("value", Value);
                    }
                    if (!string.IsNullOrWhiteSpace(Type))
                    {
                        output.Attributes.Add("type", Type);
                    }
                    else
                    {
                        output.Attributes.Add("type", "submit");
                    }
                    break;
                default:
                    break;
            }

            output.Attributes.Add("data-module", "govuk-button");
            if (Attributes != null)
            {
                foreach (var Attribute in Attributes)
                {
                    output.Attributes.Add(Attribute.Item1, Attribute.Item1);
                }
            }

            if (Element.Equals(ButtonType.button) || Element.Equals(ButtonType.input))
            {
                if (!string.IsNullOrWhiteSpace(Name))
                {
                    output.Attributes.Add("name", Name);
                }
                if (Disabled)
                {
                    output.Attributes.Add("disabled", "disabled");
                    output.Attributes.Add("aria-disabled", "true");
                }
                if (PreventDoubleClick)
                {
                    output.Attributes.Add("data-prevent-double-click", "true");
                }
            }
        }
    }
}
