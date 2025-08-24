using Mediator.Models;
using MediatR;

namespace Mediator.Queries
{
    public class ReadUserByIdQuery: IRequest<UserModel>
    {
        public int Id { get; set; }
        public ReadUserByIdQuery( int id)
        {
            Id = id;
        }
    }
}
