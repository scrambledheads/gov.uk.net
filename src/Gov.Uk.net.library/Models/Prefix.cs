using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;

namespace Gov.Uk.Net.Library.Models
{
    public class Prefix
    {
        public string Text { get; set; }
        public IHtmlContent Html { get; init; }
        public List<string> Classes { get; set; }
        public List<Tuple<string, string>> Attributes { get; set; }
    }
}
