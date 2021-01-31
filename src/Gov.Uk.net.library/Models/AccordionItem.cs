using Microsoft.AspNetCore.Html;

namespace Gov.Uk.Net.Library.Models
{
    public record AccordionItem
    {
        public AccordionItem(string heading, string summary, string content,  bool? expanded)
        {
            HeadingText = heading;
            SummaryText = summary;
            ContentText = content;
            Expanded = expanded ?? false;
        }

        public AccordionItem(IHtmlContent heading, string summary, string content,  bool? expanded)
        {
            HeadingHTML = heading;
            SummaryText = summary;
            ContentText = content;
            Expanded = expanded ?? false;
        }

        public AccordionItem(IHtmlContent heading, string summary, IHtmlContent content,  bool? expanded)
        {
            HeadingHTML = heading;
            SummaryText = summary;
            ContentHTML = content;
            Expanded = expanded ?? false;
        }

        public AccordionItem(string heading, string summary, IHtmlContent content, bool? expanded)
        {
            HeadingText = heading;
            SummaryText = summary;
            ContentHTML = content;
            Expanded = expanded ?? false;
        }

        public AccordionItem(string heading, IHtmlContent summary, IHtmlContent content, bool? expanded)
        {
            HeadingText = heading;
            SummaryHTML = summary;
            ContentHTML = content;
            Expanded = expanded ?? false;
        }

        public AccordionItem(string heading, IHtmlContent summary, string content, bool? expanded)
        {
            HeadingText = heading;
            SummaryHTML = summary;
            ContentText = content;
            Expanded = expanded ?? false;
        }

        public AccordionItem(IHtmlContent heading, IHtmlContent summary, string content, bool? expanded)
        {
            HeadingHTML = heading;
            SummaryHTML = summary;
            ContentText = content;
            Expanded = expanded ?? false;
        }

        public AccordionItem(IHtmlContent heading, IHtmlContent summary, IHtmlContent content, bool? expanded)
        {
            HeadingHTML = heading;
            ContentHTML = content;
            SummaryHTML = summary;
            Expanded = expanded ?? false;
        }

        public string HeadingText { get; init; }
        public IHtmlContent HeadingHTML { get; init; }

        public string ContentText { get; init; }
        public IHtmlContent ContentHTML { get; init; }

        public string SummaryText { get; init; }
        public IHtmlContent SummaryHTML { get; init; }

        public bool Expanded { get; init; }
    }
}
