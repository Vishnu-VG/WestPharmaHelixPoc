using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WestPharma.Feature.Accounts.Models
{
    /// <summary>
    /// Model to store the account details.
    /// </summary>
    public class UserAccountDetails
    {
        public string UserFullName { get; set; }
        public string UserEmail { get; set; }

    }
}