using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WestPharma.Foundation.Accounts.Models
{
    public class ProfileImageModel
    {
        public byte[] ImageBytes { get; set; }
        public string Extension { get; set; }
    }
}