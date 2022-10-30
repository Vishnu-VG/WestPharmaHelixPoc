using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.ContentSearch;

namespace WestPharma.Foundation.Indexing.Services
{
    public interface ISearchIndexResolver
    {
        ISearchIndex GetIndex(string indexName);
    }
}