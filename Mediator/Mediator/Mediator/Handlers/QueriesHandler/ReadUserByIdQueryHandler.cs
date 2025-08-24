using Mediator.Interfaces;
using Mediator.Models;
using Mediator.Queries;
using MediatR;

namespace Mediator.Handlers.QueriesHandler
{
    public class ReadUserByIdQueryHandler : IRequestHandler<ReadUserByIdQuery , UserModel>
    {
        private readonly IUsersServices _usersServices;

        public ReadUserByIdQueryHandler(IUsersServices usersServices)
        {
            _usersServices = usersServices;

        }
        public async Task<UserModel> Handle(ReadUserByIdQuery request , CancellationToken cancellationToken)
        {
            return _usersServices.GetUserById(request.Id);
        }
    }
}
