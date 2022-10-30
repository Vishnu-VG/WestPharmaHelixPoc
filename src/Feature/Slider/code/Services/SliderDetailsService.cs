using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WestPharma.Feature.Slider.Models;
using Sitecore.Links.UrlBuilders;

namespace WestPharma.Feature.Slider.Services
{
    public class SliderDetailsService : ISliderDetailsService
    {
        public SliderDetailsService()
        {
            //constructur
        }
        /// <summary>
        /// Method to fetch slides stored under the parent item.
        /// Returns the fetched items as list of items.
        /// </summary>
        /// <param name="rootItem"></param>
        /// <returns></returns>
        public IEnumerable<Item> GetSliderItems(Item rootItem)
        {
            //List<SliderModel> sliderData = new List<SliderModel>();
            try
            {
                //Get sub items from the root item data source having slider template as the template item
                //helps in restricting wrong template items adding to the component.
                var slideItems = rootItem.GetChildren().Where(x => x.TemplateID == ISliderTemplateConstants.TemplateId);
                return slideItems;

                #region Old code using custom model. Commented as editing from experience editor won't work!
                //if (slideItems == null || slideItems.Count() == 0)
                //    return sliderData;

                //foreach (var slide in slideItems)
                //{
                //    //Read Slider item text
                //    SliderModel slideItem = new SliderModel();
                //    slideItem.Text = slide.Fields[ISliderTemplateConstants.TextFieldID].ToString();
                //    //Read general link from slider item 
                //    Sitecore.Data.Fields.LinkField urlLinkField = slide.Fields[ISliderTemplateConstants.MainLinkFieldId];
                //    slideItem.RedirectURL = (!string.IsNullOrEmpty(urlLinkField.Url) ? urlLinkField.Url : string.Empty);
                //    //Read image field from slider item
                //    var imageField = (ImageField)slide.Fields[ISliderTemplateConstants.ImageFieldId];
                //    //If the image COntains Broken Links
                //    if (imageField.MediaItem != null)
                //    {
                //        slideItem.AltText = imageField.Alt;
                //        slideItem.ImageURL = Sitecore.Resources.Media.MediaManager.GetMediaUrl(imageField.MediaItem);
                //    }
                //    sliderData.Add(slideItem);
                //}
                #endregion

            }
            catch (Exception ex)
            {
                throw ex;
            }
            //return sliderData;
            //return null;
        }
    }
}