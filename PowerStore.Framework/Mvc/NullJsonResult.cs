using Microsoft.AspNetCore.Mvc;

namespace PowerStore.Framework.Mvc
{
    public class NullJsonResult : JsonResult
    {
        public NullJsonResult() : base(null)
        {
        }
    }
}
