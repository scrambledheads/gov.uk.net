using Gov.Uk.Net.Library.Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Gov.uk.net.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<AccordionItem> Items;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Items = new List<AccordionItem>()
            {
                new AccordionItem("Writing well for the web", string.Empty, new HtmlString("<p class=\"govuk-body\">This is the content for Writing well for the web.</p>"), false),
                new AccordionItem("Writing well for specialists", string.Empty, new HtmlString("<p class=\"govuk-body\">This is the content for Writing well for specialists.</p>"), false),
                new AccordionItem("Know your audience", string.Empty, new HtmlString("<p class=\"govuk-body\">This is the content for Know your audience.</p>"), false),
                new AccordionItem("How people read", string.Empty, new HtmlString("<p class=\"govuk-body\">This is the content for How people read.</p>"), false)
            };
        }
    }
}
