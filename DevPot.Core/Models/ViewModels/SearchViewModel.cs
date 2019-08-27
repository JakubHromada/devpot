using System;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Models;
using PublishedContentModels =  Umbraco.Web.PublishedContentModels;

namespace DevPot.Core.Models.ViewModels
{
    public class SearchViewModel : ContentModel
    {
        public PublishedContentModels.Search StrongContent { get; set; }
        public IEnumerable<PublishedSearchResult> SearchResult { get; set; }

        public SearchViewModel(IPublishedContent content) : base(content)
        {
            StrongContent = new PublishedContentModels.Search(content);
        }
    }
}
