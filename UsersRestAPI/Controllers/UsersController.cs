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
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // GET api/users
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_userService.GetAll());
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = _userService.GetById(id);
            if (user == null) return NotFound();
            return Ok(user);

        }

        // POST api/users
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            if (user == null) return BadRequest();
            return new ObjectResult(_userService.Create(user));
        }

        // PUT api/users/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] User user)
        {
            if (user == null) return BadRequest();
            return new ObjectResult(_userService.Update(user));
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            return NoContent();
        }
    }
}
