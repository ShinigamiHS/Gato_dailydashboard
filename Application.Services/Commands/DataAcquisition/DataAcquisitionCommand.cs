using Application.DTO.DataAcquisition;
using MediatR;

namespace Application.Services.Commands.DataAcquisition
{
    public class DataAcquisitionCommand : IRequest<DataAcquisitionCommandResponse>
    {
        public DataAcquisitionCommand(DataAcquisitionCommandRequest dataAcquisitionRequest)
        {
            this.dataAcquisitionRequest = dataAcquisitionRequest;
        }

        public DataAcquisitionCommandRequest dataAcquisitionRequest { get; }
    }
}
