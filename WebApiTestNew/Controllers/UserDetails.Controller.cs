using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTestNew.Models;

namespace WebApiTestNew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetails : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUser()
        {
            if (false) return BadRequest("Bad stuff Happen");

            List<User> objNames = new List<User>() {
                new User() {UID=001, FirstName = "John", LastName = "Doe", Location = "Frankfort", ZIP="40601" },
                new User() {UID=002, FirstName = "Bob", LastName = "jackson", Location ="Frankfort", ZIP="40601" },
                new User() {UID=003, FirstName = "Nic", LastName = "Lee", Location ="Frankfort", ZIP="40601" },
                new User() {UID=004, FirstName = "Larsen", LastName = "Zack", Location ="Shelbyville", ZIP="40065" },
                new User() {UID=004, FirstName = "James", LastName = "Rogger", Location ="Shelbyville", ZIP="40065" },
                new User() {UID=004, FirstName = "Tim", LastName = "Cook", Location ="Louisville", ZIP="40202" },
                new User() {UID=004, FirstName = "Harry", LastName = "Jackson", Location ="Louisville", ZIP="40205" },
                new User() {UID=004, FirstName = "Nick", LastName = "Thompson", Location ="Louisville", ZIP="40205" },
                new User() {UID=004, FirstName = "Josh", LastName = "Kim", Location ="Louisville", ZIP="40205" },
            };
            return Ok(objNames);
        }
        
    }
}
