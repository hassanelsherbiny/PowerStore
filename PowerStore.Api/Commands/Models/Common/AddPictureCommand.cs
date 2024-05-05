using PowerStore.Api.DTOs.Common;
using MediatR;

namespace PowerStore.Api.Commands.Models.Common
{
    public class AddPictureCommand : IRequest<PictureDto>
    {
        public PictureDto PictureDto { get; set; }
    }
}
