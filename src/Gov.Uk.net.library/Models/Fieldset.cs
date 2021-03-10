using System.Collections.Generic;

namespace Gov.Uk.Net.Library.Models
{
    public class Fieldset
    {
        public string DescribedBy { get; set; }
        public Legend Legend { get; set; }
        public Hint Hint { get; set; }
        public ErrorMessage ErrorMessage { get; set; }
        public FormGroup FormGroup { get; set; }
        public string IdPrefix { get; set; }
        public string Name { get; set; }
        public List<CheckboxItem> Items { get; set; }
    }
}
