using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;

namespace Gov.Uk.Net.Library.Models
{
    public class Label
    {
        public string Text { get; set; }
        public IHtmlContent Html { get; init; }
        public HtmlString For { get; set; }
        public bool IsPageHeading { get; set; }
        public List<string> Classes { get; set; }
        public List<Tuple<string, string>> Attributes { get; set; }
    }
}
