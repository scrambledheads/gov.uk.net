using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Logging;

namespace Gov.Uk.Net.Library.Components
{
    [HtmlTargetElement("a")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class AnchorTagHelperComponentTagHelper : TagHelperComponentTagHelper
    {
        public AnchorTagHelperComponentTagHelper(ITagHelperComponentManager componentManager, ILoggerFactory loggerFactory)
            : base(componentManager, loggerFactory)
        {
        }
    }
}