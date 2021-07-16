using Microsoft.AspNetCore.Mvc;

namespace Week4Api.Controllers
{
    public class UserController : ControllerBase
    {
        [HttpGet("api/users")]
        public string[] GetUsers()
        {
            return new string[] { "Umar", "Burhan", "John" };
        }
    }
}