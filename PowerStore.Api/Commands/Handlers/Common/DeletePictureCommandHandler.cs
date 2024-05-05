using PowerStore.Api.Commands.Models.Common;
using PowerStore.Services.Media;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Api.Commands.Handlers.Common
{
    public class DeletePictureCommandHandler : IRequestHandler<DeletePictureCommand, bool>
    {
        private readonly IPictureService _pictureService;

        public DeletePictureCommandHandler(IPictureService pictureService)
        {
            _pictureService = pictureService;
        }

        public async Task<bool> Handle(DeletePictureCommand request, CancellationToken cancellationToken)
        {
            var picture = await _pictureService.GetPictureById(request.PictureDto.Id);
            if (picture != null)
            {
                await _pictureService.DeletePicture(picture);
            }

            return true;

        }
    }
}
