using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clean_architecture.Core.Interfaces;
using clean_architecture.infastrcured.Brokers;
using clean_architecture.infastrcured.persistnace;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace clean_architecture.infastrcured
{
    public static class infastrcuredRegisration
    {

        public static void AddinfastrcuredRegisration(this WebApplicationBuilder webApplication)
        {
            webApplication.Services.AddTransient(typeof(IRepository<>) , typeof(Repository<>));
            webApplication.Services.AddTransient(typeof(IDendnencyInjectionDeparment) , typeof(DendnencyInjectionDeparment));
            webApplication.Services.AddTransient(typeof(IDendnencyInjectionUser) , typeof(DendnencyInjectionUser));
            webApplication.Services.AddTransient(typeof(ICirculardependency) , typeof(Circulardependency));

            webApplication.Services.AddScoped<MainBroker,MainBroker >();
            webApplication.Services.AddScoped<IExternalService, ExternalServices>();
            
        }
    }
}
