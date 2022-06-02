using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTServerWindGenerator.Managers;
using RESTServerWindGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTServerWindGenerator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WindGeneratorsController : ControllerBase
    {
        //reference til Manager klassen, et objekt oprettes
        //private WindGeneratorsManager _manager = new WindGeneratorsManager();

        //A object of the IWindGeneratorsManager interface
        //Removed the initialization here, as it needs
        //the context from the Constructor
        private readonly IWindGeneratorsManager _manager;

        //Added this constructor to be able to use the WindContext in the Manager
        public WindGeneratorsController(WindContext context)
        {
            //an if statement could be implemented here,
            //telling the Service which Manager to use
            _manager = new WindGeneratorDB(context);
        }

        // GET: api/<WindGeneratorsController>
        //Standard http metode GET
        //action result så statuskoderne kan anvendes
        //Gets all wind in the managers list
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            IEnumerable<Wind> result = _manager.GetAll();
            if (result.Count() == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // GET api/<WindGeneratorsController>/5
        //filter - speed
        //Is able to filter the result by either:
        //Name containing the substring (case-insensitive)
        //Quality is more or equal to minimumQuality
        //Quantity is more or equal to minimumQuantity
        [HttpGet("{speed}")]
        public IEnumerable<Wind> Get(int speed)
        {
            return _manager.GetFilter(speed);
        }

        // POST api/<WindGeneratorsController>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [HttpPost]
        public ActionResult<Wind> Post([FromBody] Wind newWind)
        {
            Wind result = _manager.AddWind(newWind);
            if (result == null)
            {
                return null;
            }
            return Created($"/api/wind/{result.ID}", result);
        }

        // PUT api/<WindGeneratorsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<WindGeneratorsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
