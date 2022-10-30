using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WestPharma.Feature.Search.Models
{
    public class SearchResultModel
    {
        public string Headline { get; set; }
        public string Abstract { get; set; }
        public DateTime Modifieddate { get; set; }
    }
}