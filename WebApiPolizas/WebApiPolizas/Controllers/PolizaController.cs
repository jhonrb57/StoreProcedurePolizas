using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiPolizas.Data;
using WebApiPolizas.Models;

namespace WebApiPolizas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolizaController : ControllerBase
    {
        // GET: api/<PolizaController>
        [HttpGet]
        public List<Poliza> Get()
        {
            return PolizaData.Listar();
        }

        // GET api/<PolizaController>/5
        [HttpGet("{id}")]
        public Poliza Get(int id)
        {
            return PolizaData.Obtener(id);
        }

        // POST api/<PolizaController>
        [HttpPost]
        public bool Post([FromBody] Poliza poliza)
        {
            return PolizaData.Registrar(poliza);
        }

        // PUT api/<PolizaController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Poliza poliza)
        {
            return PolizaData.Modificar(poliza);
        }

        // DELETE api/<PolizaController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return PolizaData.Eliminar(id);
        }
    }
}
