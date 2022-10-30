using Sitecore.ContentSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace WestPharma.Foundation.Indexing.Services
{
    public class SearchService : ISearchService
    {
        //constuctor
        public SearchService()
        {
            //Constructor code
        }
        /// <summary>
        /// Search on specific index with predicate constructed in Feature.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="searchIndex"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<T> SearchOnIndex<T>(ISearchIndex searchIndex, Expression<Func<T, bool>> where = null)
        {
            List<T> result = null;
            try
            {
                using (new Sitecore.SecurityModel.SecurityEnabler())
                {
                    //Create search contaxt with isearchindex
                    using (var context = searchIndex.CreateSearchContext())
                    {
                        if (context != null)
                        {

                            //Fetch records from index
                            if (where == null)
                            {
                                result = context.GetQueryable<T>().ToList();
                                return result;
                            }

                            result = context.GetQueryable<T>().Where(where).ToList();
                            return result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //Handle exception. Currently just throwing the exception caught.
                throw ex;
            }
            return null;
        }
    }
}