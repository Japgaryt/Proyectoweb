using API_REST_CONTA.Context;
using API_REST_FULL_CONTA.Entity;
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
    public class Asientos_ContablesController : ControllerBase
    {
        public AppDBContext context { get; }
        public Asientos_ContablesController(AppDBContext context)
        {
            this.context = context;
        }

        // GET: api/<AsientoscontablessController>
        [HttpGet]
        public IEnumerable<Asientos_Contables> Get()
        {
            return context.Asientos_Contables.ToList();
        }

        // GET api/<AsientoscontablessController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AsientoscontablessController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AsientoscontablessController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AsientoscontablessController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
