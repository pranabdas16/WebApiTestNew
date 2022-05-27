using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTestNew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoreCodeCamp : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCamps()
        {

            if (false) return BadRequest("Bad stuff Happen");

            return Ok(new { Moniker = "ATL2018", Name = "Atlanta code camp" });
        }
    }
}
