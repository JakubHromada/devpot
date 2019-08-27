using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace DevPot.Core.Search
{
    public class ArticleExamineComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Components().Append<ArticleExamineComponent>();
            composition.RegisterUnique<ArticleExamineIndexCreator>();
        }
    }
}