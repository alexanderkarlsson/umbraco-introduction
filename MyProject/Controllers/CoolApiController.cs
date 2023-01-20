using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Dictionary;
using Umbraco.Cms.Web.Common;
using Umbraco.Cms.Web.Common.Controllers;

namespace MyProject.Controllers
{
    /// <summary>
    /// Example of Umbraco API controller, https://docs.umbraco.com/umbraco-cms/reference/routing/umbraco-api-controllers
    /// </summary>
    [Route("cool/[action]")]
    public class CoolApiController : UmbracoApiController
	{
        private readonly UmbracoHelper _umbracoHelper;

        public CoolApiController(UmbracoHelper umbracoHelper)
        {
            _umbracoHelper = umbracoHelper;
        }

        public string GetCoolerName(string name)
        {
            var coolerName = $"{name} {_umbracoHelper.GetDictionaryValue("Cooler")}";
            return coolerName;
        }
    }
}