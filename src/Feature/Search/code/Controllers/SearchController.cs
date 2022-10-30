using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WestPharma.Feature.Search.Services;

namespace WestPharma.Feature.Search.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult GetSearchData()
        {
            ISearchProvider searchProvider = new SearchProvider();
            return View(searchProvider.GetSearchResults());
        }
    }
}