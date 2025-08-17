using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_architecture.infastrcured.Brokers
{
    public partial class MainBroker
    {

        public string Get(string url )
        {
            return $"{url}";
        }

        public string GetByid(string url,string id)
        {
            return $"{url} {id}";
        }
    }
}
