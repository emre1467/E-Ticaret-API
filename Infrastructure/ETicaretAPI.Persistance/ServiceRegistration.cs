using Microsoft.EntityFrameworkCore;
using ETicaretAPI.Persistance.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using ETicaretAPI.Application.Repositories.Customerr;
using ETicaretAPI.Persistance.Repositories.Customerr;
using ETicaretAPI.Application.Repositories.Orderr;
using ETicaretAPI.Application.Repositories.Productt;

namespace ETicaretAPI.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            //services.AddSingleton<IProductService,ProductService>();

            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configurations.ConnectionString));

            services.AddScoped<ICustomerReadRepository,CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository,CustomerWriteRepository>();

            services.AddScoped<IOrderWriteRepository,OrderWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();

            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
        }
    }
}
