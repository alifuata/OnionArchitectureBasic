using Microsoft.Extensions.DependencyInjection;
using Onion.Application.Abstractions;
using Onion.Persistence.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Persistence
{
    public static class ServiceRegistration 
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductService, ProductService>();
        }
    }
}
