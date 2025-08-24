using Mediator.Interfaces;
using Mediator.Models;
using Mediator.Queries;
using Mediator.Services;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mediator.Controllers
{
    [Route("api/v1/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly IMediator _mediator;

        public UsersController(IMediator Mediator)
        {
            _mediator = Mediator;
        }
        [HttpGet("GetAllUsers")]
        public ActionResult<IEnumerable<UserModel>> GetUsers()
        {
           var query = new ReadUserQuery();
            var Oresult = _mediator.Send(query);

            return Ok(Oresult);
        }

        [HttpGet("GetUser/{id}")]
        public ActionResult<UserModel> GetUserById(int id)
        {
            var query = new ReadUserByIdQuery(id);
            var Oresult = _mediator.Send(query);

            return Ok(Oresult);
        }
        //[HttpPost("AddUser")]
        //public ActionResult<UserModel> AddUser(UserModel userModel)
        //{
        //    //_userServices.AddUser(userModel);
        //    //return CreatedAtAction(nameof(GetUserById) , new { id = userModel.Id } , userModel);

        //}
    }
}
