using System.Collections.Generic;
using Umbraco.Web.Models;
using Umbraco.Web.PublishedContentModels;

namespace DevPot.Core.Services
{
    public interface IArticleListService
    {
        IEnumerable<Article> Get();
    }
}