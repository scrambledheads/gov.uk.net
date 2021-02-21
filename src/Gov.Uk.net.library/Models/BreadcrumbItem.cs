using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;

namespace Gov.Uk.Net.Library.Models
{
    public record BreadcrumbItem
    {
        public string Text { get; init; }
        public IHtmlContent HTML { get; init; }
        public string Href { get; init; }
        public List<Tuple<string, string>> Attributes { get; set; }

        public BreadcrumbItem(IHtmlContent html, string href, List<Tuple<string, string>> attributes = null)
        {
            HTML = html;
            Href = href;
            Attributes = attributes;
        }

        public BreadcrumbItem(string text, string href, List<Tuple<string, string>> attributes = null)
        {
            Text = text;
            Href = href;
            Attributes = attributes;
        }
    }
}
