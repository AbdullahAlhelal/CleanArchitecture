using System;
using System.Linq;

namespace clean_architecture.infastrcured.Brokers
{
    public partial class MainBroker
    {

        HttpClient _client;
        public MainBroker()
        {
            _client = new HttpClient();
        }
    }
}
