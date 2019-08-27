using System.Collections.Generic;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;
using Umbraco.Web.PublishedContentModels;

namespace DevPot.Core.Models.ViewModels
{
    public class HomeViewModel : ContentModel
    {
        public Home StrongContent { get; set; }
        public IEnumerable<Article> Articles { get; set; }

        public HomeViewModel(IPublishedContent content) : base(content)
        {
            StrongContent = new Home(content);
        }
    }
}