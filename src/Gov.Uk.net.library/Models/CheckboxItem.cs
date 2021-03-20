using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;

namespace Gov.Uk.Net.Library.Models
{
    public class CheckboxItem
    {
        public CheckboxItem()
        {
            Attributes = new List<Tuple<string, string>>();
        }
        public string Text { get; set; }
        public IHtmlContent HTML { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public Label Label { get; set; }
        public Hint Hint { get; set; }
        public bool Checked { get; set; }
        public bool Conditional { get; set; }
        public HtmlString ConditionalHtml { get; set; }
        public bool Disabled { get; set; }
        public int MyProperty { get; set; }
        public List<Tuple<string, string>> Attributes { get; set; }
    }
}