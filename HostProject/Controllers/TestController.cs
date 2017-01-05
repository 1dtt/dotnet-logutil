using System;
using System.Web.Http;
using LogUtil;

namespace HostProject.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        [Route("api/test")]
        public IHttpActionResult Test()
        {
            FileLogger.Error("OK", new Exception("test"));
            return Ok("OK");
        } 
    }
}
