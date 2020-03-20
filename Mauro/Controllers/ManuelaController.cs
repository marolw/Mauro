using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Mauro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManuelaController : ControllerBase
    {
        // GET: api/Manuela
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Zak", "Manuela2" };
        }

        // GET: api/Manuela/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "El numero 5";
        }

        // POST: api/Manuela
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Manuela/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
