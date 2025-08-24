using Mediator.Interfaces;
using Mediator.Models;
using Mediator.Queries;
using MediatR;

namespace Mediator.Handlers.QueriesHandler
{
    public class ReadUserQueryHandler : IRequestHandler<ReadUserQuery , List<UserModel>>
    {
        private readonly IUsersServices _usersServices;

        public ReadUserQueryHandler(IUsersServices usersServices)
        {
            _usersServices = usersServices;

        }
        public async Task<List<UserModel>> Handle(ReadUserQuery request , CancellationToken cancellationToken)
        {
            return _usersServices.GetUsers();
        }
    } 
}
