using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsersRestAPI.Model;
using UsersRestAPI.Services.Implementations;

namespace UsersRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionsController : ControllerBase
    {
        private IPermissionService _permissionService;

        public PermissionsController(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        // GET api/permissions
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_permissionService.GetAll());
        }

        // GET api/permissions/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var permission = _permissionService.GetById(id);
            if (permission == null) return NotFound();
            return Ok(permission);

        }

        // POST api/permissions
        [HttpPost]
        public IActionResult Post([FromBody] Permission permission)
        {
            if (permission == null) return BadRequest();
            return new ObjectResult(_permissionService.Create(permission));
        }

        // PUT api/permissions/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Permission permission)
        {
            if (permission == null) return BadRequest();
            return new ObjectResult(_permissionService.Update(permission));
        }

        // DELETE api/permissions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _permissionService.Delete(id);
            return NoContent();
        }
    }
}
