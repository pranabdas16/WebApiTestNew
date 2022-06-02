using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTestNew.Controllers
{
    //http://localhost:6600/api/CoreCodeCamp
    [Route("api/[controller]")]
    [ApiController]
    public class CoreCodeCamp : ControllerBase
    {
        //[HttpGet]
        //public IActionResult GetCamps()
        //{

        //    if (false) return BadRequest("Bad stuff Happen");

        //    return Ok(new { Moniker = "ATL2018", Name = "Atlanta code camp" }
            
        //              );
        //}

        [HttpGet]
        public IActionResult GetBootCamps()
        {

            if (false) return BadRequest("Bad stuff Happen");

            List<MonikerName> objNames = new List<MonikerName>() {
                new MonikerName() {Moniker = "ATL2018", Name = "Atlanta code camp on 2018" },
                new MonikerName() {Moniker = "ATL2019", Name = "Atlanta code camp on 2019" },
                new MonikerName() {Moniker = "ATL2020", Name = "Atlanta code camp on 2020" },
                new MonikerName() {Moniker = "ATL2021", Name = "Atlanta code camp on 2021" }

            };
            return Ok(objNames);
        }

        //public List<MonikerName> GetMonikerNames()
        //{
        //    List<MonikerName> objNames = new List<MonikerName>() { 
        //        new MonikerName() {Moniker = "ATL2018", Name = "Atlanta code camp on 2018" },
        //        new MonikerName() {Moniker = "ATL2019", Name = "Atlanta code camp on 2019" },
        //        new MonikerName() {Moniker = "ATL2020", Name = "Atlanta code camp on 2020" },
        //        new MonikerName() {Moniker = "ATL2021", Name = "Atlanta code camp on 2021" }

        //    };

        //    return objNames;
        //}
    }

    public class MonikerName
    {
        public string Moniker { get; set; }
        public string Name { get; set; }

    }
    

}
