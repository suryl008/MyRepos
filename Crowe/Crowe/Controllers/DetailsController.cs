using System.Web.Http;

namespace Crowe.Controllers
{
    public class DetailsController : ApiController
    {
        [HttpGet]
        [Route("api/Crowe/GetHeartbeat")]
        public string GetStatusMessage()
        {
            return "Hello World";
        }
    }
}
