using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApi.Model;
using RestApi.Services;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService personService;
        public PersonController(IPersonService personService)
        {
            this.personService = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var person = personService.FindAll();
            if (person.Count == 0)
                return NotFound();

            return Ok(person);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var person = personService.FindById(id);
            if (person == null)
                return NotFound();

            return Ok(person);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Person person)
        {
            if (person == null)
                return BadRequest();

            return Ok(personService.Create(person));
        }

        [HttpPut]
        public IActionResult Update([FromBody] Person person)
        {
            if (person == null)
                return BadRequest();

            return Ok(personService.Update(person));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            personService.Delete(id);
            return NoContent();
        }
    }
}
