using PowerStore.Core.Mapper;
using PowerStore.Services.Tax;
using PowerStore.Web.Areas.Admin.Models.Tax;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class ITaxProviderMappingExtensions
    {
        public static TaxProviderModel ToModel(this ITaxProvider entity)
        {
            return entity.MapTo<ITaxProvider, TaxProviderModel>();
        }
    }
}