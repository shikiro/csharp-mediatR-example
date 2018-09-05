using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shikiro.LearnMediatR.Contract;

namespace Shikiro.LearnMediatR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : BaseController
    {
        ILogger logger;
        IMediator mediator;

        public ValuesController(ILogger<ValuesController> logger, IMediator mediator)
        {
            this.logger = logger;
            this.mediator = mediator;
        }

        // GET api/values
        [HttpGet]
        public async Task<ProductResponse> Get([FromQuery]ProductRequest request)
        {
            var result = await mediator.Send(request);
            //var result = await Excute(request);
            //logger.LogError("执行时间:" + watch.ElapsedTicks.ToString());
            return result;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
