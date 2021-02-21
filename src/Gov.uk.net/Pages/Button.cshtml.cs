using Gov.Uk.Net.Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gov.uk.net.Pages
{
    public class ButtonModel : PageModel
    {
        private readonly ILogger<ButtonModel> _logger;

        public ButtonModel(ILogger<ButtonModel> logger)
        {
            _logger = logger;


        }

        public void OnGet()
        {

        }
    }
}
