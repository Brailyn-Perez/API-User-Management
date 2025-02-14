using Microsoft.AspNetCore.Mvc;
using Users.Daos;
using Users.Interfaces;
using Users.Models;
using Users.Models.UsersModels;

namespace Users.Controllers
{
    [ApiController]
    [Route("Api/Users")]
    public class UsersController : ControllerBase
    {
        private readonly IDaoUsers _daoUsers;
        public UsersController(IDaoUsers daoUsers) 
        {
            _daoUsers = daoUsers;
        }

        [HttpPost]
        public IActionResult Put(CreateUserModel users)
        {
           return Ok();
        }

    }
}
