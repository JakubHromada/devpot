using DevPot.Core.Services;
using Umbraco.Core.Composing;
using Umbraco.Core;

namespace DevPot.Core.Composers
{
    public class ArticleListComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<IArticleListService, ArticleListService>(Lifetime.Singleton);
        }
    }
}