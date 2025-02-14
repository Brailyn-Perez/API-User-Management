using Microsoft.AspNetCore.Mvc;
using Users.Daos;
using Users.Interfaces;
using Users.Models;
using Users.Models.UsersModels;
using Users.ResultPattern;

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
        public async Task<ActionResult<OperationResult<string>>> Put(CreateUserModel users)
        {

            var model = new Entities.Users()
            {
                Name = users.Name,
                Email = users.Email,
                Birthdate = users.Birthdate
            };

           var result = await _daoUsers.CreateAsync(model);
           return result;
        }
    }
}
