using System;

namespace PowerStore.Framework.Components
{
    public class BaseViewComponentAttribute : Attribute
    {
        public bool AdminAccess { get; set; }
    }
}
