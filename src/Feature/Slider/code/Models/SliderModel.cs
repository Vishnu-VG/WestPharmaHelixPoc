using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WestPharma.Feature.Slider.Models
{
    public class SliderModel
    {
        //Keeping the fields in current model as string.
        //If Glassmapper is used, sync could be performed and the templates will be generated of the specified type.
        public string Text { get; set; }
        public string ImageURL { get; set; }
        public string AltText { get; set; }
        public string RedirectURL { get; set; }

    }
    /// <summary>
    /// Static class with template IDs synced from Sitecore.
    /// Random GUIDs are used in this case.
    /// </summary>
    public static partial class ISliderTemplateConstants
    {

        public const string TemplateIdString = "A5D08881-2602-493D-B0F9-1DA89D509683";
        public static readonly ID TemplateId = new ID(TemplateIdString);
        public const string TemplateName = "Slider";

        public static readonly ID TextFieldID = new ID("D148592C-5CC1-44F0-9680-BCA25C282704");

        public static readonly ID ImageFieldId = new ID("04176A3B-8B04-43ED-83FC-27DE09DCB99C");

        public static readonly ID MainLinkFieldId = new ID("33F47B7B-8C2E-4287-969D-E7253AF5B695");

    }
}
