using DevPot.Core.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace DevPot.Core.Controllers
{
    public class SearchController : RenderMvcController
    {
        public override ActionResult Index(ContentModel model)
        {
            var searchTerm = Request.QueryString["s"];

            var viewModel = new SearchViewModel(model.Content)
            {
                SearchResult = Umbraco.ContentQuery.Search(searchTerm, string.Empty, "articleIndex")
            };

            return CurrentTemplate(viewModel);
        }
    }
}