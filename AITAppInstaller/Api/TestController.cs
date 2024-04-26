using System;
using System.Web.Http;

namespace AIT.Xtime.WebHost.Api
{
    [RoutePrefix("test")]
    public class TestController : ApiController
    {
        //GET /api/test
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(DateTimeOffset.Now);
        }
    }
}
