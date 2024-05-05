using PowerStore.Core.Mapper;
using PowerStore.Domain.Directory;
using PowerStore.Web.Areas.Admin.Models.Directory;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class CurrencyMappingExtensions
    {
        public static CurrencyModel ToModel(this Currency entity)
        {
            return entity.MapTo<Currency, CurrencyModel>();
        }

        public static Currency ToEntity(this CurrencyModel model)
        {
            return model.MapTo<CurrencyModel, Currency>();
        }

        public static Currency ToEntity(this CurrencyModel model, Currency destination)
        {
            return model.MapTo(destination);
        }
    }
}