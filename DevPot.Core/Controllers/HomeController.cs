using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using DevPot.Core.Models.ViewModels;
using DevPot.Core.Services;

namespace DevPot.Core.Controllers
{
    public class HomeController : RenderMvcController
    {
        private readonly IArticleListService _articleListService;

        public HomeController(IArticleListService articleListService)
        {
            _articleListService = articleListService;
        }

        public override ActionResult Index(ContentModel model)
        {
            var viewModel = new HomeViewModel(model.Content)
            {
                Articles = _articleListService.Get()
            };

            return CurrentTemplate(viewModel);
        }
    }
}
