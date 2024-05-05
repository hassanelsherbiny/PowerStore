using PowerStore.Core.Mapper;
using PowerStore.Domain.Messages;
using PowerStore.Web.Areas.Admin.Models.Messages;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class ContactUsMappingExtensions
    {
        public static ContactFormModel ToModel(this ContactUs entity)
        {
            return entity.MapTo<ContactUs, ContactFormModel>();
        }
    }
}