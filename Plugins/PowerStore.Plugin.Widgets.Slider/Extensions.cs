using PowerStore.Core.Mapper;
using PowerStore.Core.Models;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Stores;
using PowerStore.Framework.Localization;
using PowerStore.Framework.Mapping;
using PowerStore.Framework.Mvc.Models;
using PowerStore.Plugin.Widgets.Slider.Domain;
using PowerStore.Plugin.Widgets.Slider.Models;
using PowerStore.Services.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace PowerStore.Plugin.Widgets.Slider
{
    public static class MyExtensions
    {
        public static SlideModel ToModel(this PictureSlider entity)
        {
            return entity.MapTo<PictureSlider, SlideModel>();
        }

        public static PictureSlider ToEntity(this SlideModel model)
        {
            return model.MapTo<SlideModel, PictureSlider>();
        }


        public static SlideListModel ToListModel(this PictureSlider entity)
        {
            return entity.MapTo<PictureSlider, SlideListModel>();
        }

        public static async Task PrepareStoresMappingModel<T>(this T basePowerStoreEntityModel, IStoreMappingSupported storeMapping, bool excludeProperties, IStoreService _storeService)
            where T : BaseEntityModel, IStoreMappingModel
        {
            basePowerStoreEntityModel.AvailableStores = (await _storeService
               .GetAllStores())
               .Select(s => new StoreModel { Id = s.Id, Name = s.Shortcut })
               .ToList();
            if (!excludeProperties)
            {
                if (storeMapping != null)
                {
                    basePowerStoreEntityModel.SelectedStoreIds = storeMapping.Stores.ToArray();
                }
            }
        }
        public static List<LocalizedProperty> ToLocalizedProperty<T>(this IList<T> list) where T : ILocalizedModelLocal
        {
            var local = new List<LocalizedProperty>();
            foreach (var item in list)
            {
                Type[] interfaces = item.GetType().GetInterfaces();
                PropertyInfo[] props = item.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy);
                foreach (var prop in props)
                {
                    bool insert = true;

                    foreach (var i in interfaces)
                    {
                        if (i.HasProperty(prop.Name))
                        {
                            insert = false;
                        }
                    }

                    if (insert && prop.GetValue(item) != null)
                        local.Add(new LocalizedProperty() {
                            LanguageId = item.LanguageId,
                            LocaleKey = prop.Name,
                            LocaleValue = prop.GetValue(item).ToString(),
                        });
                }
            }
            return local;
        }
        public static bool HasProperty(this Type obj, string propertyName)
        {
            return obj.GetProperty(propertyName) != null;
        }
    }


}