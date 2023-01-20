using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Models;

namespace MyProject.Models
{
	public class LandingPageViewModel : ContentModel
	{
		public LandingPageViewModel(IPublishedContent? content) : base(content)
		{
		}

		public string? Heading { get; set; }
        public string? CoolName { get; internal set; }
    }
}
