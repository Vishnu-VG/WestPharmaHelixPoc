using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WestPharma.Feature.Search.Models;
using WestPharma.Foundation.Indexing.Services;

namespace WestPharma.Feature.Search.Services
{
    public class SearchProvider : ISearchProvider
    {
        ISearchService _searchService;
        ISearchIndexResolver _searchIndexResolver;
        public SearchProvider()
        {
            _searchService = new SearchService();
            _searchIndexResolver = new SearchIndexResolver();
        }
        /// <summary>
        /// Used to search on index.
        /// ISearchIndex and predicate are passed to the Foundation layer Search Service.
        /// </summary>
        /// <returns></returns>
        public List<SearchResultModel> GetSearchResults()
        {
            List<SearchResultModel> result = new List<SearchResultModel>();
            try
            {
                ISearchIndex index = _searchIndexResolver.GetIndex("index-name");
                var predicate = PredicateBuilder.True<SearchResultModel>();
                result = _searchService.SearchOnIndex<SearchResultModel>(index, predicate);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}