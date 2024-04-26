using System;
using System.Web.Http;

namespace AIT.Xtime.WebHost.Api
{
    [RoutePrefix("lydon")]
    public class LydonController : ApiController
    {
        //GET /api/lydon
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok("Hello, World!!");
        }

        //POST /api/lydon/dosomething
        [Route("DoSomething")]
        [HttpPost]
        public IHttpActionResult DoSomething()
        {
            return Ok("We did something!!");
        }
    }
}
