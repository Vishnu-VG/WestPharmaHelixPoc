using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WestPharma.Feature.FeedImport.Services;

namespace WestPharma.Feature.FeedImport.Controllers
{
    public class FeedImportController : Controller
    {
        // GET: FeedImport
        public ActionResult ImportFeed()
        {
            IFeedImportService feedImportService = new FeedImportService();
            return View(feedImportService.ImportFeedData());
        }
    }
}