using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WestPharma.Feature.Accounts.Services;

namespace WestPharma.Feature.Accounts.Controllers
{
    /// <summary>
    /// Class handling the accounts
    /// </summary>
    public class AccountsController : Controller
    {
        private IAccountServices accountServices;
        /// <summary>
        /// Constructor to initialize dependencies
        /// </summary>
        public AccountsController()
        {
            accountServices = new AccountServices();
            //Constructor code
        }
        // GET: Account details and pass it to corresponding view
        public ActionResult AccountDetails()
        {
            return View(accountServices.GetAccountDetails("myemail@sample.com", "Full Name"));
        }
    }
}
