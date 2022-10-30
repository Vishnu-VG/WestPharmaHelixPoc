using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WestPharma.Feature.Accounts.Models;
using WestPharma.Foundation.Accounts.Models;

namespace WestPharma.Feature.Accounts.Services
{
    public class AccountServices:IAccountServices
    {
        /// <summary>
        /// Account Services constructor
        /// </summary>
        public AccountServices()
        {
            //constructor
        }
        /// <summary>
        /// Get account details.
        /// Called from constructor
        /// </summary>
        /// <param name="email"></param>
        /// <param name="fullName"></param>
        /// <returns></returns>
        public UserAccountDetails GetAccountDetails(string email, string fullName)
        {
            var userAccount = new UserAccountDetails { UserEmail = email, UserFullName = fullName };
            return userAccount;
        }
    }
}