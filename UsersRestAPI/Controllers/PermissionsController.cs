using Microsoft.AspNetCore.Mvc;
using UsersRestAPI.Model;
using UsersRestAPI.Business;

namespace UsersRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionsController : ControllerBase
    {
        private IPermissionBusiness _permissionBusiness;

        public PermissionsController(IPermissionBusiness permissionBusiness)
        {
            _permissionBusiness = permissionBusiness;
        }

        // GET api/permissions
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_permissionBusiness.GetAll());
        }

        // GET api/permissions/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var permission = _permissionBusiness.GetById(id);
            if (permission == null) return NotFound();
            return Ok(permission);

        }

        // POST api/permissions
        [HttpPost]
        public IActionResult Post([FromBody] Permission permission)
        {
            if (permission == null) return BadRequest();
            return new ObjectResult(_permissionBusiness.Create(permission));
        }

        // PUT api/permissions/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Permission permission)
        {
            if (permission == null) return BadRequest();
            return new ObjectResult(_permissionBusiness.Update(permission));
        }

        // DELETE api/permissions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _permissionBusiness.Delete(id);
            return NoContent();
        }
    }
}
