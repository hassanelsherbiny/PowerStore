using PowerStore.Core.Mapper;
using PowerStore.Domain.Messages;
using PowerStore.Web.Areas.Admin.Models.Messages;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class EmailAccountMappingExtensions
    {
        public static EmailAccountModel ToModel(this EmailAccount entity)
        {
            return entity.MapTo<EmailAccount, EmailAccountModel>();
        }

        public static EmailAccount ToEntity(this EmailAccountModel model)
        {
            return model.MapTo<EmailAccountModel, EmailAccount>();
        }

        public static EmailAccount ToEntity(this EmailAccountModel model, EmailAccount destination)
        {
            return model.MapTo(destination);
        }
    }
}