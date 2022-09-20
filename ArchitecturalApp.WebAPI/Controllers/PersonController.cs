using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArchitecturalApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        [HttpGet("getbyid")]
        public IActionResult AddPerson(int id)
        {
            var result = _personService.GetById(id);
            return Ok(result);
        }
        [HttpGet("getbyall")]
        public IActionResult GetList()
        {
            var result = _personService.GetAllPerson();
            return Ok(result);
        }
        [HttpPost("add")]
        public IActionResult AddPerson(Person person)
        {
            _personService.AddEntity(person);
            return Ok();
        }
        [HttpPost("delete")]
        public IActionResult Remove(Person person)
        {
            _personService.PersontToDelete(person);
            return Ok();
        }
        [HttpPost("deletebyid")]
        public IActionResult RemoveById(int id)
        {
            _personService.DeleteById(id);
            return Ok();
        }


    }
}
