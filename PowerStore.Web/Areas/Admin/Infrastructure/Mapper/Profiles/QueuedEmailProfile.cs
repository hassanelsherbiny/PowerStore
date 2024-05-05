using AutoMapper;
using PowerStore.Domain.Messages;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Messages;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class QueuedEmailProfile : Profile, IAutoMapperProfile
    {
        public QueuedEmailProfile()
        {
            CreateMap<QueuedEmail, QueuedEmailModel>()
                .ForMember(dest => dest.CreatedOn, mo => mo.Ignore())
                .ForMember(dest => dest.PriorityName, mo => mo.Ignore())
                .ForMember(dest => dest.DontSendBeforeDate, mo => mo.Ignore())
                .ForMember(dest => dest.SendImmediately, mo => mo.Ignore())
                .ForMember(dest => dest.SentOn, mo => mo.Ignore());

            CreateMap<QueuedEmailModel, QueuedEmail>()
                .ForMember(dest => dest.Id, mo => mo.Ignore())
                .ForMember(dest => dest.Priority, dt => dt.Ignore())
                .ForMember(dest => dest.PriorityId, dt => dt.Ignore())
                .ForMember(dest => dest.CreatedOnUtc, dt => dt.Ignore())
                .ForMember(dest => dest.DontSendBeforeDateUtc, mo => mo.Ignore())
                .ForMember(dest => dest.SentOnUtc, mo => mo.Ignore())
                .ForMember(dest => dest.EmailAccountId, mo => mo.Ignore())
                .ForMember(dest => dest.AttachmentFilePath, mo => mo.Ignore())
                .ForMember(dest => dest.AttachmentFileName, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}