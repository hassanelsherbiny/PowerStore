using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using PowerStore.Framework.Localization;
using PowerStore.Framework.Mapping;
using PowerStore.Framework.Mvc.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Plugin.Widgets.Slider.Models
{
    public partial class SlideModel : BaseEntityModel, ILocalizedModel<SlideLocalizedModel>, IStoreMappingModel
    {
        public SlideModel()
        {
            Locales = new List<SlideLocalizedModel>();
            AvailableCategories = new List<SelectListItem>();
            AvailableManufacturers = new List<SelectListItem>();
            AvailableStores = new List<StoreModel>();
        }
        [PowerStoreResourceDisplayName("Plugins.Widgets.Slider.Name")]
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Widgets.Slider.Description")]
        public string Description { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Widgets.Slider.Link")]
        public string Link { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Widgets.Slider.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Widgets.Slider.Published")]
        public bool Published { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Widgets.Slider.FullWidth")]
        public bool FullWidth { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Widgets.Slider.SliderType")]
        public int SliderTypeId { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Widgets.Slider.Picture")]
        [UIHint("Picture")]
        public string PictureId { get; set; }

        public IList<SlideLocalizedModel> Locales { get; set; }

        //Store mapping
        [PowerStoreResourceDisplayName("Plugins.Widgets.Slider.LimitedToStores")]
        public bool LimitedToStores { get; set; }
        [PowerStoreResourceDisplayName("Plugins.Widgets.Slider.AvailableStores")]
        public List<StoreModel> AvailableStores { get; set; }
        public string[] SelectedStoreIds { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Widgets.Slider.Category")]
        public string CategoryId { get; set; }
        public IList<SelectListItem> AvailableCategories { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Widgets.Slider.Manufacturer")]
        public string ManufacturerId { get; set; }
        public IList<SelectListItem> AvailableManufacturers { get; set; }

    }

    public partial class SlideLocalizedModel : ILocalizedModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Widgets.Slider.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Widgets.Slider.Description")]

        public string Description { get; set; }

    }
}
