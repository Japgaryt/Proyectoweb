using API_REST_CONTA.Context;
using API_REST_CONTA.Entity;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_REST_CONTA.Controllers
{
    //[EnableCors("MyCorsImplementationPilicy")]
    [Route("api/[controller]")]
    [ApiController]
    //[EnableCors("MyCorsImplementationPilicy")]
    public class ProductosController : ControllerBase
    {
        public AppDBContext context { get; }

        public ProductosController(AppDBContext context)
        {
            this.context = context;
        }
        // GET: api/<ProductosController>
        [HttpGet]
        public IEnumerable<Productos> Get()
        {
            return context.Productos.ToList();
        }

        // GET api/<ProductosController>/5
        [HttpGet("{id}")]
        public Productos Get(string id)
        {
            var producto = context.Productos.FirstOrDefault(p => p.codigo_producto  == id);
            return producto;
        }

        // POST api/<ProductosController>
        [HttpPost]
        public ActionResult Post([FromBody] Productos productos)
        {
            try
            {
                context.Productos.Add(productos);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

        }

        // PUT api/<ProductosController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Productos productos)
        {
            if (productos.id_producto == id)
            {
                context.Entry(productos).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/<ProductosController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var producto = context.Productos.FirstOrDefault(p => p.codigo_producto == id);
            if (producto != null)
            {

                context.Productos.Remove(producto);
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
