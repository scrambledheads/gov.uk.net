using Microsoft.AspNetCore.Html;
using System.Collections.Generic;

namespace Gov.Uk.Net.Library.Models
{
    public class Legend
    {
        public Legend(string text, List<string> classes, bool isPageHeading = false)
        {
            Text = text;
            Classes = classes;
            IsPageHeading = isPageHeading;
        }
        public Legend(HtmlString html, List<string> classes, bool isPageHeading = false)
        {
            Html = html;
            Classes = classes;
            IsPageHeading = isPageHeading;
        }
        public string Text { get;  }
        public HtmlString Html { get;  }
        public List<string> Classes { get; }
        public bool IsPageHeading { get; }
    }
}
