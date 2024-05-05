using AutoMapper;
using PowerStore.Domain.Documents;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Documents;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class DocumentTypeProfile : Profile, IAutoMapperProfile
    {
        public DocumentTypeProfile()
        {
            CreateMap<DocumentType, DocumentTypeModel>();
            CreateMap<DocumentTypeModel, DocumentType>()
                .ForMember(dest => dest.Id, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}