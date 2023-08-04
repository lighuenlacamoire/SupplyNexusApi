using ECommerce.Infrastructure.Implements;
using ECommerce.Infrastructure.Interfaces;
using ECommerce.Infrastructure.ORM;
using ECommerce.Services.Implements;
using ECommerce.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services.Support
{
    public static class ServicesStartup
    {
        public static IServiceCollection AddCCServices(
            this IServiceCollection services)
        {
            services.AddTransient<ITiendaService, TiendaService>();
            
            return services;
        }
    }
}
