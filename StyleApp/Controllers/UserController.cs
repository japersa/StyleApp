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

            List<User> value = new List<User>();
            User user0 = new User();
            user0.Id = 1;
            user0.Name = "Alvaro Perez";
            user0.Email = "japersa92@gmail.com";
            value.Add(user0);

            User user1 = new User();
            user1.Id = 2;
            user1.Name = "Laura";
            user1.Email = "laura@gmail.com";
            value.Add(user1);

            User user2 = new User();
            user2.Id = 3;
            user2.Name = "Angie";
            user2.Email = "Angie@gmail.com";
            value.Add(user2);
            return base.Ok(value);
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
