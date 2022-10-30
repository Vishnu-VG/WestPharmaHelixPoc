using WestPharma.Foundation.Accounts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WestPharma.Foundation.Accounts.Services
{
    public class AccountServices : IAccountServices
    {
        public AccountServices()
        {
            //constructor
        }
        /// <summary>
        /// Method to fetch details from db.
        /// TODO: Incomplete code
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public ProfileImageModel GetProfileImage(string email)
        {
            //getProfile image from DB
            //Common functionality for all brands
            return null;
        }
    }
}