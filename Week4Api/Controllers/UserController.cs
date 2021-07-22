using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Week4Api.Database;

namespace Week4Api.Controllers
{
    public class UserController : ControllerBase
    {
        [HttpGet("api/users")]
        public List<User> GetUsers()
        {
            var db = new Week4Context();

            return db.Users.ToList();
        }
    }
}