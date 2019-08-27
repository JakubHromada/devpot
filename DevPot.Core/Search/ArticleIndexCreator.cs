using Examine;
using Lucene.Net.Analysis.Standard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Logging;
using Umbraco.Core.Services;
using Umbraco.Examine;
using Umbraco.Web.Search;
using Lucene.Net.Util;

namespace DevPot.Core.Search
{
    public class ArticleExamineIndexCreator : LuceneIndexCreator, IUmbracoIndexesCreator
    {
        private readonly IProfilingLogger _profilingLogger;
        private readonly ILocalizationService _localizationService;
        private readonly IPublicAccessService _publicAccessService;

        public ArticleExamineIndexCreator(IProfilingLogger profilingLogger,
            ILocalizationService localizationService,
            IPublicAccessService publicAccessService
        )
        {
            _profilingLogger = profilingLogger;
            _localizationService = localizationService;
            _publicAccessService = publicAccessService;
        }

        public override IEnumerable<IIndex> Create()
        {
            var index = new UmbracoContentIndex("ArticleIndex",
                CreateFileSystemLuceneDirectory("ArticleIndex"),
                new UmbracoFieldDefinitionCollection(),
                new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30),
                _profilingLogger,
                _localizationService,
                new ContentValueSetValidator(true, false, _publicAccessService, includeItemTypes: new string[] { "article" }));

            return new[] { index };
        }
    }
}