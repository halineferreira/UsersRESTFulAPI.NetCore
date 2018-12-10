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
    public class RolesController : ControllerBase
    {
        private IRoleService _roleService;

        public RolesController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        // GET api/roles
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_roleService.GetAll());
        }

        // GET api/roles/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var role = _roleService.GetById(id);
            if (role == null) return NotFound();
            return Ok(role);

        }

        // POST api/roles
        [HttpPost]
        public IActionResult Post([FromBody] Role role)
        {
            if (role == null) return BadRequest();
            return new ObjectResult(_roleService.Create(role));
        }

        // PUT api/roles/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Role role)
        {
            if (role == null) return BadRequest();
            return new ObjectResult(_roleService.Update(role));
        }

        // DELETE api/roles/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _roleService.Delete(id);
            return NoContent();
        }
    }
}
