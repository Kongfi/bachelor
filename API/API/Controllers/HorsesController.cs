using API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class HorsesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Horse>> Get()
        {
            var horses = new List<Horse>()
            {
                new Horse
                {
                    FeifID = "IS2000186130",
                    Name = "Kvistur",
                    From = "frá",
                    Stable = "Skagaströnd",
                    Gender = "Hingst"
                },
                new Horse
                {
                    FeifID = "IS20041387371",
                    Name = "Hestur",
                    From = "frá",
                    Stable = "Ommestrup",
                    Gender = "Hingst"
                },
            };
            return Ok(horses);
        }

        [HttpPost]
        public ActionResult<Horse> Post([FromBody] Horse body) {
            return Created("", body);
        }

        //[HttpPut("{id}")]
        //public ActionResult<Horse> Put(
        //    [FromRoute] int id,
        //    [FromBody] Horse body)
        //{
        //    var newHorse = new Horse();
        //    return Created("", newHorse);
        //}

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id) {
            return NoContent();
        }
    }
}
