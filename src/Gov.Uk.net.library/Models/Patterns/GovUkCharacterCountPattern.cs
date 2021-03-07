using System;
using System.Collections.Generic;

namespace Gov.Uk.Net.Library.Models.Patterns
{
    public class GovUkCharacterCountPattern
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Rows { get; set; }
        public string Value { get; set; }
        public int MaxLength { get; set; }
        public int MaxWords { get; set; }
        public int Threshold { get; set; }
        public Label Label { get; set; }
        public Hint Hint { get; set; }
        public ErrorMessage ErrorMessage { get; set; }
        public FormGroup FormGroup { get; set; }
        public List<string> Classes { get; set; }
        public List<Tuple<string, string>> Attributes { get; set; }
        public bool SpellCheck { get; set; }
        public CountMessage CountMessage { get; set; }
    }
}
