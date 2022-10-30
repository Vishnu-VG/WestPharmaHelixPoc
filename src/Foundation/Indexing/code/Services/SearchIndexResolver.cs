using Sitecore.ContentSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WestPharma.Foundation.Indexing.Services
{
    public class SearchIndexResolver: ISearchIndexResolver
    {
        /// <summary>
        /// Get ISearchIndex for the context creation
        /// </summary>
        /// <param name="indexName"></param>
        /// <returns></returns>
        public ISearchIndex GetIndex(string indexName)
        {
            return ContentSearchManager.GetIndex(indexName);
        }
    }
}