using Application.DTO.Entities;

namespace Application.DTO.DataAcquisition
{
    public class DataAcquisitionCommandRequest
    {
        public User? User { get; set; } = null; //Guest Users - Null
    }
}
