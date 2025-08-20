using clean_architecture.Core.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace clean_architecture.infastrcured.Brokers
{
    public partial class MainBroker
    {
        private readonly IExternalService _ExternalService;
        private readonly IConfiguration _Configuration;


        HttpClient _client;
        public MainBroker(IExternalService externalService, IConfiguration configuration )
        {
            _client = new HttpClient();
            _ExternalService = externalService;
            _Configuration = configuration;
        }
    }
}
