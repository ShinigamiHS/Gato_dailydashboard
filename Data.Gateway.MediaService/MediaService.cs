using Data.Gateway.MediaService.DTO;
using Data.Gateway.MediaService.Interfaces;

namespace Data.Gateway.MediaService
{
    public class MediaService : IMediaService
    {
        private readonly IMediaServiceClient mediaServiceClient;

        public MediaService(IMediaServiceClient mediaServiceClient)
        {
            this.mediaServiceClient = mediaServiceClient;
        }

        public Task<Media> GetMediaAsync()
        {
            throw new NotImplementedException();
        }
    }
}
