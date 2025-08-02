using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_architecture.Core.Interfaces
{
    public interface IUser
    {
        void AddUser();
        void GetUserById();
        void GetAll();
    }

    public interface IMailSender
    {
        void SendMail();
    }
    public class MailSender : IMailSender
    {
        public void SendMail()
        {
            throw new NotImplementedException();
        }
    }

    public class User : IUser, IMailSender
    {
        public void AddUser()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetUserById()
        {
            throw new NotImplementedException();
        }

        public void SendMail()
        {
            throw new NotImplementedException();
        }
    }
}
