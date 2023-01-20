using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Common;
using Umbraco.Cms.Web.Website.Controllers;

namespace MyProject.Controllers
{
    /// <summary>
    /// Example of API controller, https://docs.umbraco.com/umbraco-cms/reference/routing/umbraco-api-controllers
    /// </summary>
    public class CoolSurfaceController : SurfaceController
	{
        private readonly UmbracoHelper _umbracoHelper;

        public CoolSurfaceController(IUmbracoContextAccessor umbracoContextAccessor, 
			IUmbracoDatabaseFactory databaseFactory, 
			ServiceContext services, 
			AppCaches appCaches, 
			IProfilingLogger profilingLogger, 
			IPublishedUrlProvider publishedUrlProvider,
			UmbracoHelper umbracoHelper) 
			: base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
            _umbracoHelper = umbracoHelper;
        }

        [HttpPost]
		public async Task<IActionResult> MakeItCool(string name)
		{
			var coolName = $"{name} {_umbracoHelper.GetDictionaryValue("Cool")}";

            TempData["CoolName"] = coolName;

			//var httpClient = new HttpClient();
			//var response = await httpClient.GetAsync($"{Request.Scheme}://{Request.Host.Value}/Cool/GetCoolerName?name={name}");
			//var responseValue = await response.Content.ReadAsStringAsync();
			//TempData["CoolName"] = responseValue;

			return RedirectToCurrentUmbracoPage();
		}
	}
}