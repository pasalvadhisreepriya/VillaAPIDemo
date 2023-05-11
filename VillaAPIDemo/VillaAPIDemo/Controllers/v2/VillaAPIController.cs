using Microsoft.AspNetCore.Mvc;

namespace VillaAPIDemo.Controllers.v2
{
   
        [Route("api/v{version:apiVersion}/villaAPI")]
        [ApiController]
        
        [ApiVersion("2.0")]
        public class VillaAPIController : ControllerBase
        {
           
            [HttpGet]

            public IEnumerable<string> Get()
            {
                return new string[] { "qwer", "poiu" };
            
        }
    }
}
