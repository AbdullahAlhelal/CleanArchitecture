using clean_architecture.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_architecture.infastrcured
{
    internal class DendnencyInjectionUser : IDendnencyInjectionUser
    {
        public string GetNameByUserID(Guid userid)
        {
          return  $"Salay of {userid.ToString()} is 1$"  ;
        }

        public string GetUserNameByUserID(Guid userid)
        {
            return $"Name of {userid.ToString()} is ahmad$";
        }
    }

    internal class DendnencyInjectionDeparment : IDendnencyInjectionDeparment
    {

        private readonly IDendnencyInjectionUser _User;

        public DendnencyInjectionDeparment(IDendnencyInjectionUser dendnencyInjectionUser)
        {
                _User = dendnencyInjectionUser; 
        }
        public string GetUserDeparmentByUserID(Guid userid)
        {
            return $"Deparment of {userid.ToString()} is F$";
        }

        public string GetUserNameAndJobByUserID(Guid userid)
        {
            return $"Name of {userid.ToString()} is {_User.GetNameByUserID(userid)}  And job is tester$";
        }
    }

}
