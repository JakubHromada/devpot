using DevPot.Core.Models.ViewModels;
using System.Collections.Specialized;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace DevPot.Core.Controllers
{
    public class SearchSurfaceController : SurfaceController
    {
        [HttpPost]
        public ActionResult Search(SearchFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }

            NameValueCollection queryString = new NameValueCollection
            {
                ["s"] = model.SearchTerm
            };

            return new RedirectToUmbracoPageResult(7076, queryString);
        }
    }
}