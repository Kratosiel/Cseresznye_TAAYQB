using CseresznyeWebApp.Stocks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CseresznyeWebApp.Controllers
{
    [Route("api/Ibmprice")]
    [ApiController]
    public class StockController : ControllerBase
    {
        // GET: api/<StockController>
        [HttpGet]
        public IActionResult Get()
        {
            StockadatokContext context = new StockadatokContext();
            return Ok(context.Ibmprices.ToList());
        }
        // GET api/<StockController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StockController>
        [HttpPost]
        public void Post([FromBody] Ibmprice ibmprice)
        {
            StockadatokContext context = new StockadatokContext();
            context.Ibmprices.Add(ibmprice);
            context.SaveChanges();
        }

        // PUT api/<StockController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StockController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
