using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    
    public class BaseController : ControllerBase
    {
        private IMediator? _mediator;

        protected IMediator Mediator { get { return _mediator ??= HttpContext.RequestServices.GetRequiredService<IMediator>();} }
    }
}
