using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using DevPot.Core.Models.ViewModels;
using DevPot.Core.Services;

namespace DevPot.Core.Controllers
{
    public class ArticleListController : RenderMvcController
    {
        private readonly IArticleListService _articleListService;

        public ArticleListController(IArticleListService articleListService)
        {
            _articleListService = articleListService;
        }

        public override ActionResult Index(ContentModel model)
        {
            var viewModel = new ArticleListViewModel(model.Content)
            {
                Articles = _articleListService.Get()
            };

            return CurrentTemplate(viewModel);
        }
    }
}
