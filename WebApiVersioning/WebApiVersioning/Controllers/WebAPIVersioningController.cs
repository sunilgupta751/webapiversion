using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiVersioning.Controllers
{
    // ye line isliye use ho rahi hai yadi ap url versioning use ker rahe ho other wise jarurat ni hai 
    //[Route("api/v{version:apiversion}/[controller]")]
    // ye niche wali line yadi aap header versioning use ker rahe ho but hamne header main "api-version" pass kerna hoga
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [ApiVersion("3.0")]
    public class WebAPIVersioningController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRecord()
        {
            return Ok("API Data");
        }
        [MapToApiVersion("1.0")]
        [HttpGet("GetRecord1")]
        public IActionResult GetRecord1()
        {
            return Ok("API Data Record 1");
        }

        [MapToApiVersion("2.0")]
        [HttpGet("GetRecord2")]
        public IActionResult GetRecord2()
        {
            return Ok("API Data Record 2");
        }
    }
}
