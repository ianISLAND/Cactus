using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetCactusName.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CactusController : ControllerBase
    {

        [HttpGet("GetCactus")]
        public IActionResult GetCactus()
        {
            var cacti = new List<Species>();
            cacti.Add(new Species("Prickly Pear", 10));
            cacti.Add(new Species("Saguaro", 8));
            cacti.Add(new Species("Ferocactus", 15));
            cacti.Add(new Species("Elephant Pear", 10));
            cacti.Add(new Species("Purple", 8));
            cacti.Add(new Species("Watermelon", 15));
            cacti.Add(new Species("Barrel", 10));
            cacti.Add(new Species("Stinky Cactus", 8));
            cacti.Add(new Species("Dick Cactus", 15));

            var r = new Random();
            return Ok(cacti[r.Next(0, cacti.Count - 1)]);
        }

    }

    public class Species
    {
        public Species(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; set; }
        public int Weight { get; set; }
    }

}
