using System;
using System.Collections.Generic;
using System.Web.Http;
using AITAppInstaller.Models;

namespace AIT.Xtime.WebHost.Api
{
    [RoutePrefix("app")]
    public class AppController : ApiController
    {
        //GET /api/app/list
        [Route("list")]
        public IHttpActionResult Get()
        {
            return Ok(new List<AppName> {
                new AppName
                {
                    Name = "Xtime"
                }
            });
        }
    }
}
