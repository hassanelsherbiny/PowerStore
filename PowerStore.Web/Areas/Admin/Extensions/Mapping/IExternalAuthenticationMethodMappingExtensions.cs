using PowerStore.Core.Mapper;
using PowerStore.Services.Authentication.External;
using PowerStore.Web.Areas.Admin.Models.ExternalAuthentication;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class IExternalAuthenticationMethodMappingExtensions
    {
        public static AuthenticationMethodModel ToModel(this IExternalAuthenticationMethod entity)
        {
            return entity.MapTo<IExternalAuthenticationMethod, AuthenticationMethodModel>();
        }
    }
}