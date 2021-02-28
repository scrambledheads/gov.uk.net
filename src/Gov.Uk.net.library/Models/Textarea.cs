using System;
using System.Collections.Generic;

namespace Gov.Uk.Net.Library.Models
{
    public class Textarea
    {
        public Textarea()
        {
  
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Spellcheck { get; set; }
        public string Rows { get; set; }
        public string Value { get; set; }
        public string DescribedBy { get; set; }
        public Label Label { get; set; }
        public Hint Hint { get; set; }
        public ErrorMessage ErrorMessage { get; set; }
        public FormGroup FormGroup { get; set; }
        public List<string> Classes { get; set; }
        public string Autocomplete { get; set; }
        public List<Tuple<string, string>> Attributes { get; set; }
    }
}
