using System.Web.Http;

namespace AccountExternalWeb.ApiControllers
{
    public class TestApiController : BaseApiController
    {
        [HttpPost]
        public IHttpActionResult Get()
        {
            return Ok(new string[] { "value1", "value2" });
        }
    }
}