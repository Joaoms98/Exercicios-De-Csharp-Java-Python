using APIEstudos.Interfaces;
using APIEstudos.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIEstudos.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserCommand _user;

        public UserController(IUserCommand user)
        {
            _user = user;
        }

        [HttpPost("/CreateUser")]
        public async Task<ActionResult> CreateUser([FromBody] CreateUserRequest request)
        {
            try
            {
                var response = await _user.CreateUserAsync(request);
                return Ok(response);
            }
            catch
            {
                return BadRequest();
            }

        }
    }
}
