using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;

namespace Gov.Uk.Net.Library.Models.Patterns
{
    public class GovUkFieldsetPattern
    {
        public List<Tuple<string, string>> Attributes { get; set; }
        public List<string> Classes { get; set; }
        public string DescribedBy { get; set; }
        public IHtmlContent HTMLContent { get; set; }
        public Legend Legend { get; set; }
        public string Role { get; set; }
    }
}
