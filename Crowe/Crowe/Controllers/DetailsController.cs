using System.Collections.Generic;
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

        public List<string> GetDbEntity()
        {
            return new List<string> { "lets do it..." };
        }
    }
}
