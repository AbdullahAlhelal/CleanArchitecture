using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_architecture.Core.Interfaces
{
    public interface IDendnencyInjectionUser
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userid"></param>
        /// <returns>  Return Salay Employee By Name </returns>
        string GetNameByUserID(Guid userid);
        string GetUserNameByUserID(Guid userid);
    } 
}
