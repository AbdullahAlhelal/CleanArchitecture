using clean_architecture.Core.Interfaces;
using clean_architecture.infastrcured;
using clean_architecture.infastrcured.persistnace;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clean_architecture.Services
{
    public static  class ServicesRegisration
    {
        public static void AddservicRegisration(this WebApplicationBuilder webApplication)
        {
            webApplication.Services.AddTransient(typeof(ICarServices) , typeof(CarServices));
            
        }
    }
}
