using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Shikiro.LearnMediatR.Controllers
{
    public class BaseController: ControllerBase
    {
        public async Task<T> Excute<T>(IRequest<T> request) where T: class
        {
            var mediator = (IMediator)this.HttpContext.RequestServices.GetService(typeof(IMediator));
            return await mediator.Send(request);
        }
    }
}
