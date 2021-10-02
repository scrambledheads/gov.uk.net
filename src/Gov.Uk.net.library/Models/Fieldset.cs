using System.Collections.Generic;

namespace Gov.Uk.Net.Library.Models
{
    public class Fieldset
    {
        public Fieldset(Legend legend, string DescribedBy = null, Hint hint = null, ErrorMessage errorMessage = null, 
            FormGroup formGroup = null, string idPrefix = null, string name = null, List<CheckboxItem> items = null)
        {
            Legend = legend;
            this.DescribedBy = DescribedBy;
            Hint = hint;
            ErrorMessage = errorMessage;
            FormGroup = formGroup;
            IdPrefix = idPrefix;
            Name = name;
            Items = items;
        }
        public string DescribedBy { get; set; }
        public Legend Legend { get; init; }
        public Hint Hint { get; set; }
        public ErrorMessage ErrorMessage { get; set; }
        public FormGroup FormGroup { get; set; }
        public string IdPrefix { get; set; }
        public string Name { get; set; }
        public List<CheckboxItem> Items { get; set; }
    }
}
