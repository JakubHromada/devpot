using Examine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace DevPot.Core.Search
{
    public class ArticleExamineComponent : IComponent
    {
        private readonly IExamineManager _examineManager;
        private readonly ArticleExamineIndexCreator _articleExamineIndexCreator;

        public ArticleExamineComponent(IExamineManager examineManager, ArticleExamineIndexCreator productIndexCreator)
        {
            _examineManager = examineManager;
            _articleExamineIndexCreator = productIndexCreator;
        }

        public void Initialize()
        {
            foreach (var index in _articleExamineIndexCreator.Create())
            {
                _examineManager.AddIndex(index);
            }
        }

        public void Terminate() { }
    }
}