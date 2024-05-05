using PowerStore.Core.Models;
using System.Collections.Generic;

namespace PowerStore.Plugin.Widgets.Slider.Models
{
    public class PublicInfoModel : BaseModel
    {
        public PublicInfoModel()
        {
            Slide = new List<Slider>();
        }
        public IList<Slider> Slide { get; set; }

        public class Slider
        {
            public string PictureUrl { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Link { get; set; }
            public bool FullWidth { get; set; }
            public string CssClass { get; set; }

        }

    }
}