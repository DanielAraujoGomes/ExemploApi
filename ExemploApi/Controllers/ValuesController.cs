using System.Linq;
using ExemploApi.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace ExemploApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ControladoriaContext _context;
        private IHostingEnvironment _env;
        
        public ValuesController(IHostingEnvironment env)
        {
            _env = env;
            _context = new ControladoriaContext();
        }
        
        // GET api/values
        /// <summary>
        /// Obtem a lista de Usuários
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Usuarios.ToList());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(decimal id)
        {
            var obj = _context.Usuarios.Find(id);

            if (obj == null) return NotFound(id);
            
            return Ok(obj);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}