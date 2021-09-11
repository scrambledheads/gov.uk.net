using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using System;
using System.IO;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Gov.Uk.Net.Library.Helpers
{
    public interface IRenderViewComponentService
    {
        Task<string> RenderViewComponentAsStringAsync<TViewComponent>(object args) where TViewComponent : ViewComponent;
    }

    public class RenderViewComponentService : IRenderViewComponentService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ITempDataProvider _tempDataProvider;
        private readonly IViewComponentHelper _viewComponentHelper;

        public RenderViewComponentService(IServiceProvider serviceProvider, ITempDataProvider tempDataProvider, IViewComponentHelper viewComponentHelper)
        {
            _serviceProvider = serviceProvider;
            _tempDataProvider = tempDataProvider;
            _viewComponentHelper = viewComponentHelper;
        }

        public async Task<string> RenderViewComponentAsStringAsync<TViewComponent>(object args) where TViewComponent : ViewComponent
        {
            var viewContext = GetFakeViewContext();
            (_viewComponentHelper as IViewContextAware).Contextualize(viewContext);

            // this appears to call InvokeAsync in TViewComponent, but it'll also call Invoke (synchronously) if it's implemented
            // see https://docs.microsoft.com/en-us/aspnet/core/mvc/views/view-components?view=aspnetcore-3.1#perform-synchronous-work
            var htmlContent = await _viewComponentHelper.InvokeAsync<TViewComponent>(args); // exception is thrown here!
            using var stringWriter = new StringWriter();
            htmlContent.WriteTo(stringWriter, HtmlEncoder.Default);
            var html = stringWriter.ToString();

            return html;
        }

        private ViewContext GetFakeViewContext(ActionContext actionContext = null, TextWriter writer = null)
        {
            actionContext ??= GetFakeActionContext();
            var viewData = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary());
            var tempData = new TempDataDictionary(actionContext.HttpContext, _tempDataProvider);

            var viewContext = new ViewContext(
                actionContext,
                NullView.Instance,
                viewData,
                tempData,
                writer ?? TextWriter.Null,
                new HtmlHelperOptions());

            return viewContext;
        }

        private ActionContext GetFakeActionContext()
        {
            var httpContext = new DefaultHttpContext
            {
                RequestServices = _serviceProvider,
            };

            var routeData = new RouteData();
            var actionDescriptor = new ActionDescriptor();

            return new ActionContext(httpContext, routeData, actionDescriptor);
        }

        private class NullView : IView
        {
            public static readonly NullView Instance = new NullView();
            public string Path => string.Empty;
            public Task RenderAsync(ViewContext context)
            {
                if (context == null) { throw new ArgumentNullException(nameof(context)); }
                return Task.CompletedTask;
            }
        }
    }
}
