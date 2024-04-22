using Application.DTO.DataAcquisition;
using Data.Gateway.MediaService.DTO;
using Data.Gateway.MediaService.Interfaces;
using MediatR;

namespace Application.Services.Commands.DataAcquisition
{
    public class DataAcquisitionCommandHandler : IRequestHandler<DataAcquisitionCommand, DataAcquisitionCommandResponse>
    {
        private readonly IMediaService mediaService;

        //Constructor with each service
        public DataAcquisitionCommandHandler(IMediaService mediaService) 
        { 
            this.mediaService = mediaService;
        }

        public async Task<DataAcquisitionCommandResponse> Handle(DataAcquisitionCommand request, CancellationToken cancellationToken)
        {
            var (media, media2) = await WhenAll(this.mediaService.GetMediaAsync(), this.mediaService.GetMediaAsync());

            return new DataAcquisitionCommandResponse();
        }

        private static async Task<(Media, Media)> WhenAll(Task<Media> mediaAsync, Task<Media> mediaAsync2) => (await mediaAsync, await mediaAsync2);
    }
}
