using PowerStore.Api.DTOs.Common;
using MediatR;

namespace PowerStore.Api.Commands.Models.Common
{
    public class DeletePictureCommand : IRequest<bool>
    {
        public PictureDto PictureDto { get; set; }
    }
}
