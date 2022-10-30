using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WestPharma.Feature.Search.Models;

namespace WestPharma.Feature.Search.Services
{
    public interface ISearchProvider
    {
        List<SearchResultModel> GetSearchResults();
    }
}