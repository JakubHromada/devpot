using ClientDependency.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.PublishedCache;
using Umbraco.Web.PublishedContentModels;
using Umbraco.Web.Mvc;

namespace DevPot.Core.Services
{
    public class ArticleListService : IArticleListService
    {
        private readonly IUmbracoContextFactory _contextFactory;

        public ArticleListService(IUmbracoContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public IEnumerable<Article> Get()
        {
            using (var contextReference = _contextFactory.EnsureUmbracoContext())
            {
                var contentCache = contextReference.UmbracoContext.Content;
                var home = contentCache?
                    .GetAtRoot()
                    .Where(x => x.ContentType.Alias == "home")?
                    .FirstOrDefault();

                var articles = home?.DescendantsOfType("article");

                return articles != null || articles.Any() 
                    ? articles.Cast<Article>() 
                    : new List<Article>();
            }
        }
    }
}