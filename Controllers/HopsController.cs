using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HopClassLib;
using HopWebApp.Managers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HopWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HopsController : ControllerBase
    {
        private readonly HopManager _manager = new HopManager();

        
        // GET: api/<HopsController>
        [HttpGet]
        public IEnumerable<Hop> GetAll()
        {
            return _manager.GetAll();
        }

        // GET api/<HopsController>/5
        [HttpGet("{id}")]
        public Hop Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<HopsController>
        [HttpPost]
        public Hop Post([FromBody] Hop value)
        {
            return _manager.Add(value);
        }


        // DELETE api/<HopsController>/5
        [HttpDelete("{id}")]
        public Hop Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}
