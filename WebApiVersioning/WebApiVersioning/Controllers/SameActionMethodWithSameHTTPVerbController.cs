using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiVersioning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SameActionMethodWithSameHTTPVerbController : ControllerBase
    {
        // if you want to get data with same method name in one controller then 
        // way 1
        [HttpGet("GetStduentRecord")]
        //way 2
        //[HttpGet]
        //[ActionName("GetStduentRecord")]
        public IActionResult GetStduentRecord([Required] string Name, string Fathername)
        {
            // Required filed -we can use  in swagger for testing as well as postman
            return Ok("GetStduentRecord");
        }

        [HttpGet("GetStduentRecord/{Name}/{Fathername}")]
        //way 2
        //[HttpGet]
        //[ActionName("GetStduentRecord")]
        public IActionResult GetStduentRecord_withSameMethodNamebutSameHttpVerb([Required] string Name, string Fathername)
        {
            // Required filed -we can use  in swagger for testing as well as postman
            return Ok("GetStduentRecord");
        }
        // way 1
        [HttpPost("GetStduentRecord")]
        //way 2
        // [HttpPost]
        //[ActionName("GetStduentRecord")]
        public IActionResult GetStduentRecordData()
        {
            return Ok("GetStduentRecord_Data");
        }
    }
}
