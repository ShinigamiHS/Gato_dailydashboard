using Application.DTO.DataAcquisition;
using dailydashboard_gateway.DTO;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace dailydashboard_gateway.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class DashboardMainController : BaseController
    {
        public DashboardMainController(ILogger<BaseController> logger, IMediator mediator) : base(logger, mediator)
        {
        }

        [Route("/v0/index")]
        [ProducesResponseType(typeof(BaseResponse<DataAcquisitionCommandResponse>), 200)]
        public async Task<BaseResponse<DataAcquisitionCommandResponse>> MainPage()
        {
            DataAcquisitionCommandRequest request = new DataAcquisitionCommandRequest();
            //TODO: Improve this
            return (BaseResponse<DataAcquisitionCommandResponse>)await base.mediator.Send(request);
        }
    }
}
