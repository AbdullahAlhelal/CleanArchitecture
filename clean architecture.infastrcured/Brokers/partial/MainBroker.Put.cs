using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_architecture.infastrcured.Brokers
{
    public partial class MainBroker
    {
        public string Put(string url , string content)
        {
            return $"{url}{content}";
        }
    }
}
