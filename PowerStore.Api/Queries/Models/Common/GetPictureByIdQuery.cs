using PowerStore.Api.DTOs.Common;
using MediatR;

namespace PowerStore.Api.Queries.Models.Common
{
    public class GetPictureByIdQuery : IRequest<PictureDto>
    {
        public string Id { get; set; }
    }
}
