using Microsoft.AspNetCore.Html;

namespace Gov.Uk.net.library.Models
{
    public class AccordionItem
    {
        public AccordionItem(IHtmlContent heading, IHtmlContent content, bool? hidden)
        {
            HeadingHTML = heading;
            ContentHTML = content;
        }

        public AccordionItem(string heading, IHtmlContent content, bool? hidden)
        {
            HeadingText = heading;
            ContentHTML = content;
        }

        public AccordionItem(string heading, string content, bool? hidden)
        {
            HeadingText = heading;
            ContentText = content;
        }

        public AccordionItem(IHtmlContent heading, string content, bool? hidden)
        {
            HeadingHTML = heading;
            ContentText = content;
        }

        public string HeadingText { get; private set; }
        public IHtmlContent HeadingHTML { get; private set; }

        public string ContentText { get; private set; }
        public IHtmlContent ContentHTML { get; private set; }
    }
}
