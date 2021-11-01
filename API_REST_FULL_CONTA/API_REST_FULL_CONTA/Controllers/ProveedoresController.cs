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
    public class ProveedoresController : ControllerBase
    {
        public AppDBContext context { get; }

        public ProveedoresController(AppDBContext context)
        {
            this.context = context;
        }
        // GET: api/<ProveedoresController>
        [HttpGet]
        public IEnumerable<Proveedores> Get()
        {
            return context.Proveedores.ToList();
        }

        // GET api/<ProveedoresController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProveedoresController>
        [HttpPost]
        //public ActionResult Post([FromBody] Productos productos)
        public ActionResult Post([FromBody] Proveedores proveedores)
        {
            try
            {
                context.Proveedores.Add(proveedores);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        // PUT api/<ProveedoresController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProveedoresController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
