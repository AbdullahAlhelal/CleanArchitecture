using Mediator.Command;
using Mediator.Interfaces;
using Mediator.Models;
using Mediator.Services;
using MediatR;

namespace Mediator.Handlers.CommandHandler
{
    public class AddUserCommandHandl : IRequestHandler<AddUserCommand , UserModel>

    {
        private readonly IUsersServices _userServices;
        public AddUserCommandHandl(IUsersServices usersServices)
        {
            _userServices = usersServices;
        }
        public async Task<UserModel> Handle(AddUserCommand request , CancellationToken cancellationToken)
        {

            var Odata = new UserModel { Id = request.Id , FirstName = request.FirstName , LastName = request.LastName };
            _userServices.AddUser(Odata);
            return await Task.FromResult(_userServices.GetUserById(Odata.Id));
        }
    }
}
