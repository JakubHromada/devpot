using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.PublishedContentModels;

namespace DevPot.Core.Models.ViewModels
{
    public class NavigationViewModel : ContentModel
    {
        public IEnumerable<IPublishedContent> NavigationItems { get; set; }
        public bool IsHome { get; set; }

        public NavigationViewModel(IPublishedContent content) : base(content)
        {
            NavigationItems = Content.AncestorOrSelf<Home>()?.Children?.Where(x => x.IsPublished());
            IsHome = Content.ContentType.Alias == "home";
        }
    }
}