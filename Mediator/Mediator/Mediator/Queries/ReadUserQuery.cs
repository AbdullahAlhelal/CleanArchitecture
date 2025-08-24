using Mediator.Models;
using MediatR;

namespace Mediator.Queries
{
    public class ReadUserQuery:IRequest<List<UserModel>>
    {
    } 
}
