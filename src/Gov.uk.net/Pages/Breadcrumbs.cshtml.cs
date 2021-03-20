using Gov.Uk.Net.Library.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Gov.uk.net.Pages
{
    public class BreadcrumbsModel : PageModel
    {
        private readonly ILogger<BreadcrumbsModel> _logger;

        public List<BreadcrumbItem> Items { get; }

        public List<string> Classes { get; set; }

        public bool CollapseOnMobile { get; set; }

        public List<Tuple<string, string>> Attributes { get; set; }

        public BreadcrumbsModel(ILogger<BreadcrumbsModel> logger)
        {
            _logger = logger;

            Items = new List<BreadcrumbItem>
            {
                new BreadcrumbItem("Home", "#"),
                new BreadcrumbItem("Passports, travel and living abroad", "#"),
                new BreadcrumbItem("Travel abroad", "#")
            };
        }

        public void OnGet()
        {

        }
    }
}
