using clean_architecture.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_architecture.infastrcured.persistnace.Data.DataServices
{
    public class SqlDBContext : IDbContextBuilder
    {
        public dynamic GetDbContextByType()
        {
            throw new NotImplementedException();
        }
    }
}
