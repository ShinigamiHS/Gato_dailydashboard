using Application.DTO.DataAcquisition;
using MediatR;

namespace Application.Services.Commands.DataAcquisition
{
    public class DataAcquisitionCommand : IRequest<DataAcquisitionResponse>
    {
        public DataAcquisitionCommand(DataAcquisitionRequest dataAcquisitionRequest)
        {
            this.dataAcquisitionRequest = dataAcquisitionRequest;
        }

        public DataAcquisitionRequest dataAcquisitionRequest { get; }
    }
}
