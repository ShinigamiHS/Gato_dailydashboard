using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace dailydashboard_gateway.Controllers
{
    public abstract class BaseController : Controller
    {
        protected readonly ILogger<BaseController> logger;
        protected readonly IMediator mediator;

        public BaseController(ILogger<BaseController> logger, IMediator mediator)
        {
            this.logger = logger;
            this.mediator = mediator;
        }
    }
}
