using Sitecore.ContentSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace WestPharma.Foundation.Indexing.Services
{
    public interface ISearchService
    {
        List<T> SearchOnIndex<T>(ISearchIndex searchIndex, Expression<Func<T, bool>> where = null);
    }
}