using Mediator.Models;

namespace Mediator.Interfaces
{
    public interface IUsersServices
    {
        public void AddUser(UserModel userModel);
        public List<UserModel> GetUsers();
        public UserModel GetUserById(int id);
    }
}
