using PowerStore.Api.Commands.Models.Common;
using PowerStore.Api.DTOs.Common;
using PowerStore.Api.Extensions;
using PowerStore.Services.Media;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Api.Commands.Handlers.Common
{
    public class AddPictureCommandHandler : IRequestHandler<AddPictureCommand, PictureDto>
    {
        private readonly IPictureService _pictureService;

        public AddPictureCommandHandler(IPictureService pictureService)
        {
            _pictureService = pictureService;
        }

        public async Task<PictureDto> Handle(AddPictureCommand request, CancellationToken cancellationToken)
        {
            var picture = await _pictureService.InsertPicture(request.PictureDto.PictureBinary, request.PictureDto.MimeType,
                request.PictureDto.SeoFilename,
                request.PictureDto.AltAttribute,
                request.PictureDto.TitleAttribute,
                request.PictureDto.IsNew);

            return picture.ToModel();

        }
    }
}
