using API_REST_CONTA.Context;
using API_REST_CONTA.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_REST_FULL_CONTA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParametrizacionesController : ControllerBase
    {
        public AppDBContext context { get; }

        public ParametrizacionesController(AppDBContext context)
        {
            this.context = context;
        }
        // GET: api/<ParametrizacionesController>
        [HttpGet]
        public IEnumerable<Parametrizaciones> Get()
        {
             return context.Parametrizaciones.ToList();
        }

        // GET api/<ParametrizacionesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ParametrizacionesController>
        [HttpPost]
        public ActionResult Post([FromBody] Parametrizaciones parametrizaciones)
        {
            try
            {
                context.Parametrizaciones.Add(parametrizaciones);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        // PUT api/<ParametrizacionesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ParametrizacionesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
