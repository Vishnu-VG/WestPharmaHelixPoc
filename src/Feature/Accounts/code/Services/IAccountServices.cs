using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WestPharma.Feature.Accounts.Models;

namespace WestPharma.Feature.Accounts.Services
{
    public interface IAccountServices
    {
        UserAccountDetails GetAccountDetails(string email, string fullName);
    }
}