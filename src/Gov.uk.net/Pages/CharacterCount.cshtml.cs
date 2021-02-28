using Gov.Uk.Net.Library.Models.Patterns;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Gov.uk.net.Pages
{
    public class CharacterCountModel : PageModel
    {
        private readonly ILogger<CharacterCountModel> _logger;
        public GovUkCharacterCountPattern CharacterCount { get; }

        public CharacterCountModel(ILogger<CharacterCountModel> logger)
        {
            _logger = logger;
            CharacterCount = new GovUkCharacterCountPattern
            {
                MaxLength = 1,
                Threshold = 2
            };
        }

        public void OnGet()
        {

        }
    }
}
