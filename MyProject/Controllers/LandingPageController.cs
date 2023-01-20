using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using MyProject.Models;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;

namespace MyProject.Controllers
{
	/// <summary>
	/// Example of url highjack, https://docs.umbraco.com/umbraco-cms/reference/routing/custom-controllers
	/// </summary>
	public class LandingPageController : RenderController
	{
		public LandingPageController(ILogger<RenderController> logger, 
			ICompositeViewEngine compositeViewEngine, 
			IUmbracoContextAccessor umbracoContextAccessor) 
			: base(logger, compositeViewEngine, umbracoContextAccessor)
		{
		}

		public override IActionResult Index()
		{
			var vm = new LandingPageViewModel(CurrentPage) { };
			vm.Heading = "What is your name?";
			vm.CoolName = TempData["CoolName"]?.ToString();

			return View("/Views/landingPage.cshtml", vm);
		}
	}
}