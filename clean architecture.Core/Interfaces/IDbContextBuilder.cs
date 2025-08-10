using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_architecture.Core.Interfaces
{
    public interface IDbContextBuilder
    {
        dynamic GetDbContextByType();
    }
}
