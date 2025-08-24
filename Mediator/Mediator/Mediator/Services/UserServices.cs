using Mediator.Interfaces;
using Mediator.Models;

namespace Mediator.Services
{
    public class UserServices : IUsersServices
    {

        private static List<UserModel> _users = new List<UserModel>
        {
            new UserModel{ Id = 1,FirstName="ahmad",LastName="helal" },
            new UserModel{ Id = 2,FirstName="mohamad",LastName="husen" },   
            new UserModel{ Id = 3,FirstName="Bayan",LastName="Bagadid" }
        };
        public void AddUser(UserModel userModel)
        {
            _users.Add(userModel);
        }

        public UserModel GetUserById(int id)
        {
            return _users.FirstOrDefault(us=>us.Id == id);
        }

        public List<UserModel> GetUsers()
        {
            return _users.ToList();
        }
    }
}
