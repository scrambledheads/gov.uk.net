﻿using Gov.Uk.Net.Library.Helpers;
using Gov.Uk.Net.Library.Models;
using Gov.Uk.Net.Library.Models.Patterns;
using Gov.Uk.Net.Library.Patterns;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Gov.uk.net.Pages
{
    public class CheckBoxesModel : PageModel
    {
        private readonly ILogger<CheckBoxesModel> _logger;
        public List<CheckBoxPageItem> Checkboxes;
        private readonly IRenderViewComponentService _renderViewComponentService;

        public CheckBoxesModel(ILogger<CheckBoxesModel> logger, IRenderViewComponentService viewRenderService)
        {
            _logger = logger;
            _renderViewComponentService = viewRenderService;

            var viewContext = new ViewContext
            { 
                HttpContext = HttpContext
            };
            var viewComponentContext = new ViewComponentContext
            {
                ViewContext = viewContext
            };

            var emailTextInput = new GovUkTextInputPattern
            {
                Id = "contact-by-email",
                Name = "contact-by-email",
                Type = "email",
                AutoComplete = "email",
                SpellCheck = false,
                Classes = new List<string>
                {
                    "govuk-!-width-one-third"
                },
                Label = new Label
                {
                    Text = "Email address"
                }
            };
            var emailString =_renderViewComponentService.RenderViewComponentAsStringAsync<GovUkTextInput>(emailTextInput).Result;

            Checkboxes = new List<CheckBoxPageItem>
            {
                //new CheckBoxPageItem
                //{
                //    CheckboxDescription = "Basic Checkboxes",
                //    Checkbox = new GovUkCheckboxesPattern
                //    {
                //        IdPrefix = "waste",
                //        Name = "waste",
                //        Fieldset = new Fieldset
                //        {
                //            Legend = new Legend(text: "Which types of waste do you transport?", classes: new List<string> {"govuk-fieldset__legend--l"}, isPageHeading: true)
                //        },
                //        Hint = new Hint
                //        {
                //            Text = "Select all that apply."
                //        },
                //        Items = new List<CheckboxItem>
                //        {
                //            new CheckboxItem
                //            {
                //                Value = "carcasses",
                //                Text = "Waste from animal carcasses"
                //            },
                //            new CheckboxItem
                //            {
                //                Value = "mines",
                //                Text = "Waste from mines or quarries"
                //            },
                //            new CheckboxItem
                //            {
                //                Value = "farm",
                //                Text = "Farm or agricultural waste"
                //            }
                //        }
                //    }
                //},
                //new CheckBoxPageItem
                //{
                //    CheckboxDescription = "Legend as Page Heading",
                //    Checkbox = new GovUkCheckboxesPattern
                //    {
                //        IdPrefix = "nationality",
                //        Name = "nationality",
                //        Fieldset = new Fieldset
                //        {
                //            Legend = new Legend(text: "What is your nationality?", classes: new List<string> {"govuk-fieldset__legend--l"}, isPageHeading: true)
                //        },
                //        Hint = new Hint
                //        {
                //            Text = "If you have dual nationality, select all options that are relevant to you."
                //        },
                //        Items = new List<CheckboxItem>
                //        {
                //            new CheckboxItem
                //            {
                //                Value = "british",
                //                Text = "British",
                //                Hint = new Hint
                //                {
                //                    Text = "including English, Scottish, Welsh and Northern Irish"
                //                }
                //            },
                //            new CheckboxItem
                //            {
                //                Value = "irish",
                //                Text = "Irish"
                //            },
                //            new CheckboxItem
                //            {
                //                Value = "other",
                //                Text = "Citizen of another country"
                //            }
                //        }
                //    }
                //},
                //new CheckBoxPageItem
                //{
                //    CheckboxDescription = "Checkbox with hints",
                //    Checkbox = new GovUkCheckboxesPattern
                //    {
                //        IdPrefix = "contact",
                //        Name = "contact",
                //        Fieldset = new Fieldset
                //        {
                //            Legend = new Legend(text: "How would you like to be contacted?", classes: new List<string> {"govuk-fieldset__legend--l"}, isPageHeading: true)
                //        },
                //        Hint = new Hint
                //        {
                //            Text = "Select all options that are relevant to you."
                //        },
                //        Items = new List<CheckboxItem>
                //        {
                //            new CheckboxItem
                //            {
                //                Value = "email",
                //                Text = "Email",
                //                ConditionalHtml = new HtmlString("")
                //            },
                //            new CheckboxItem
                //            {
                //                Value = "phone",
                //                Text = "Phone",
                //                ConditionalHtml = new HtmlString("")
                //            },
                //            new CheckboxItem
                //            {
                //                Value = "text message",
                //                Text = "Text message",
                //                ConditionalHtml = new HtmlString("")
                //            }
                //        }
                //    }
                //},
                new CheckBoxPageItem
                {
                    CheckboxDescription = "Conditionally reveal content",
                    Checkbox = new GovUkCheckboxesPattern
                    {
                        IdPrefix = "contact",
                        Name = "contact",
                        Fieldset = new Fieldset
                        {
                            Legend = new Legend(text: "How would you like to be contacted?", classes: new List<string> {"govuk-fieldset__legend--l"}, isPageHeading: true)
                        },
                        Hint = new Hint
                        {
                            Text = "Select all options that are relevant to you."
                        },
                        Items = new List<CheckboxItem>
                        {
                            new CheckboxItem
                            {
                                Value = "email",
                                Text = "Email",
                                ConditionalHtml = new HtmlString(emailString)
                            },
                            new CheckboxItem
                            {
                                Value = "phone",
                                Text = "Phone",
                                ConditionalHtml = new HtmlString("")
                            },
                            new CheckboxItem
                            {
                                Value = "text message",
                                Text = "Text message",
                                ConditionalHtml = new HtmlString("")
                            }
                        }
                    }
                }
            };
        }

        public void OnGet()
        {

        }
    }

    public class CheckBoxPageItem
    {
        public string CheckboxDescription { get; set; }
        public GovUkCheckboxesPattern Checkbox;
    }
}
