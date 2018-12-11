using Microsoft.AspNetCore.Mvc;
using UsersRestAPI.Model;
using UsersRestAPI.Business;

namespace UsersRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private IRoleBusiness _roleBusiness;

        public RolesController(IRoleBusiness roleBusiness)
        {
            _roleBusiness = roleBusiness;
        }

        // GET api/roles
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_roleBusiness.GetAll());
        }

        // GET api/roles/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var role = _roleBusiness.GetById(id);
            if (role == null) return NotFound();
            return Ok(role);

        }

        // POST api/roles
        [HttpPost]
        public IActionResult Post([FromBody] Role role)
        {
            if (role == null) return BadRequest();
            return new ObjectResult(_roleBusiness.Create(role));
        }

        // PUT api/roles/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Role role)
        {
            if (role == null) return BadRequest();
            var updatedRole = _roleBusiness.Update(role);
            if (updatedRole == null) return BadRequest();
            return new ObjectResult(_roleBusiness.Update(role));
        }

        // DELETE api/roles/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _roleBusiness.Delete(id);
            return NoContent();
        }
    }
}
