using System;
using System.Collections.Generic;

namespace Gov.Uk.Net.Library.Models.Patterns
{
    public class GovUkTextInputPattern
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string InputMode { get; set; }
        public string Value { get; set; }
        public string DescribedBy { get; set; }
        public Label Label { get; set; }
        public Hint Hint { get; set; }
        public ErrorMessage ErrorMessage { get; set; }
        public Prefix Prefix { get; set; }
        public Suffix Suffix { get; set; }
        public FormGroup FormGroup { get; set; }
        public List<string> Classes { get; set; }
        public string AutoComplete { get; set; }
        public string Pattern { get; set; }
        public bool? SpellCheck { get; set; }
        public List<Tuple<string, string>> Attributes { get; set; }
    }
}
