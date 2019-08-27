using System.Collections.Generic;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;
using Umbraco.Web.PublishedContentModels;

namespace DevPot.Core.Models.ViewModels
{
    public class ArticleListViewModel : ContentModel
    {
        public ArticleList StrongContent { get; set; }
        public IEnumerable<Article> Articles { get; set; }

        public ArticleListViewModel(IPublishedContent content) : base(content)
        {
            StrongContent = new ArticleList(content);
        }
    }
}