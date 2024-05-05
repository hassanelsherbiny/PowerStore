using PowerStore.Core.Configuration;
using PowerStore.Core.DependencyInjection;
using PowerStore.Core.TypeFinders;
using PowerStore.Plugin.Widgets.Slider.Domain;
using PowerStore.Plugin.Widgets.Slider.Services;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson.Serialization;

namespace PowerStore.Plugin.Widgets.Slider
{
    public class DependencyInjection : IDependencyInjection
    {
        public virtual void Register(IServiceCollection serviceCollection, ITypeFinder typeFinder, PowerStoreConfig config)
        {
            serviceCollection.AddScoped<SliderPlugin>();
            BsonClassMap.RegisterClassMap<PictureSlider>(cm =>
            {
                cm.AutoMap();
                cm.UnmapMember(c => c.SliderType);
            });
            serviceCollection.AddScoped<ISliderService, SliderService>();
        }

        public int Order {
            get { return 10; }
        }
    }

}
