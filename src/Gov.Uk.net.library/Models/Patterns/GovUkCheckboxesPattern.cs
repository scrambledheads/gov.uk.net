using System;
using System.Collections.Generic;

namespace Gov.Uk.Net.Library.Models.Patterns
{
    public class GovUkCheckboxesPattern
    {
        public string DescribedBy { get; set; }
        public Fieldset Fieldset { get; set; }
        public Hint Hint { get; set; }
        public ErrorMessage ErrorMessage { get; set; }
        public FormGroup FormGroup { get; set; }
        public string IdPrefix { get; set; }
        public string  Name { get; set; }
        public List<CheckboxItem> Items { get; set; }
        public List<string> Classes { get; set; }
        public List<Tuple<string, string>> Attributes { get; set; }
    }
}
