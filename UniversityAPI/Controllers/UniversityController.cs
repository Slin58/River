using Microsoft.AspNetCore.Mvc;
using River.Services.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UniversityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversityController : ControllerBase
    {
        UniversityService service;
        public UniversityController() {
            service = new UniversityService();
        }
        // GET: api/<UniversityController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UniversityController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            List<River.Data.Models.Domain.Application> list = service.GetApplications(id);
            if (list == null)
            {
                return NotFound();
            }

            return Ok(list.ToArray());
        }

        // POST api/<UniversityController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UniversityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UniversityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
