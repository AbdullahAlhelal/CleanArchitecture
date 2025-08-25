using Mediator.Models;
using MediatR;

namespace Mediator.Command
{
    public class AddUserCommand:IRequest<UserModel>
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddUserCommand(int Id,string FirstName, string LastName)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            
        }
    }
}
