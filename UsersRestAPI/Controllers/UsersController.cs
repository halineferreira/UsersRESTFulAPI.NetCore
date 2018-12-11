using System;
using Microsoft.AspNetCore.Mvc;
using UsersRestAPI.Model;
using UsersRestAPI.Business;

namespace UsersRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserBusiness _userBusiness;

        public UsersController(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }

        // GET api/users
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_userBusiness.GetAll());
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = _userBusiness.GetById(id);
            if (user == null) return NotFound();
            return Ok(user);

        }

        // POST api/users
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            if (user == null) return BadRequest();
            return new ObjectResult(_userBusiness.Create(user));
        }

        // PUT api/users/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] User user)
        {
            if (user == null) return BadRequest();
            var updatedUser = _userBusiness.Update(user);
            if (updatedUser == null) return BadRequest();
            return new ObjectResult(_userBusiness.Update(user));
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userBusiness.Delete(id);
            return NoContent();
        }
    }
}
