using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediatR;

        protected IMediator Mediator => _mediatR ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}