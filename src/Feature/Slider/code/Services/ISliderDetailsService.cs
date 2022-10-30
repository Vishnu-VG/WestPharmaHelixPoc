using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WestPharma.Feature.Slider.Models;

namespace WestPharma.Feature.Slider.Services
{
    public interface ISliderDetailsService
    {
        IEnumerable<Item> GetSliderItems(Item rootItem);
    }
}