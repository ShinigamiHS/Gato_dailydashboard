using Data.Gateway.MediaService.DTO;

namespace Data.Gateway.MediaService.Interfaces
{
    public interface IMediaService
    {
        public Task<Media> GetMediaAsync();
    }
}
