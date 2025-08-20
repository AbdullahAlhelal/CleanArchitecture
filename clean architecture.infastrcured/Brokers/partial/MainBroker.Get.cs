using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_architecture.infastrcured.Brokers
{
    public partial class MainBroker
    {
        public async ValueTask<string> Get(string url)
        {
            await _ExternalService.Get<List<MobileModel>>(_Configuration["ExternalAPiUrl"]!);
            return $"{url}";
        }

        public async ValueTask<List<MobileModel>> GetMobiles(string url)
        {
            return await _ExternalService.Get<List<MobileModel>>(url);
        }

        public string GetByid(string url , string id)
        {
            return $"{url} {id}";
        }
    }
}
