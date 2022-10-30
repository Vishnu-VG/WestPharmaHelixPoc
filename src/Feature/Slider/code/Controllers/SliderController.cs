using Sitecore.Data.Items;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WestPharma.Feature.Slider.Models;
using WestPharma.Feature.Slider.Services;

namespace WestPharma.Feature.Slider.Controllers
{
    public class SliderController : SitecoreController
    {
        ISliderDetailsService sliderDetailsService = null;
        public SliderController()
        {
            sliderDetailsService = new SliderDetailsService();
        }
        // GET: Slider
        /// <summary>
        /// Method for the controller rendering
        /// </summary>
        /// <returns></returns>
        public ActionResult GetSlider()
        {
            IEnumerable<Item> sliderData = null;
            Item item = RenderingContext.Current.Rendering.Item;
            if (item != null)
            {
                sliderData = sliderDetailsService.GetSliderItems(item);
            }
            return View("/views/Slider/Slider.cshtml", sliderData);
        }
    }
}