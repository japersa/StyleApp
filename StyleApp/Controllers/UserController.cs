using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StyleApp.Models;

namespace StyleApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new List<User>());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new User());
        }

        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] User user)
        {

            return Ok(user);
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody] User user)
        {
            if (user.Name != "")
            {
                return Ok(new User());
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

    }


}
