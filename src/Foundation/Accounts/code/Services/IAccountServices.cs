using WestPharma.Foundation.Accounts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WestPharma.Foundation.Accounts.Services
{
    public interface IAccountServices
    {
        ProfileImageModel GetProfileImage(string email);
    }
}