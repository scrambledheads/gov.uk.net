using Gov.Uk.Net.Library.Helpers;
using Gov.Uk.Net.Library.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Gov.uk.net.Pages
{
    public class FieldsetsModel : PageModel
    {
        private readonly ILogger<CheckBoxesModel> _logger;

        public FieldsetsModel(ILogger<CheckBoxesModel> logger, IRenderViewComponentService viewRenderService)
        {
            _logger = logger;

        }


        public void OnGet()
        {

        }
    }
}
