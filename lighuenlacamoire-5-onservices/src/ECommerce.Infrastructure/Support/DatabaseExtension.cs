using ECommerce.Infrastructure.Implements;
using ECommerce.Infrastructure.Interfaces;
using ECommerce.Infrastructure.ORM;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Infrastructure.Support
{
    public static class DatabaseExtension
    {

        /// <summary>
        /// Metodo extensivo para la configuracion de la base de datos
        /// </summary>
        /// <param name="services"></param>
        /// <param name="Configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddCCDatabase(
            this IServiceCollection services)
        {
            #region Unit Of Work
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            #endregion

            #region DbContext
            services.AddDbContext<DataContext>(
                options => options.UseInMemoryDatabase(databaseName: "ECommerceDb"));

            #endregion

            #region Repositories
            services.AddTransient<ITiendaRepository, TiendaRepository>();
            services.AddTransient<IPedidoRepository, PedidoRepository>();
            #endregion

            return services;
        }
        public static IApplicationBuilder UseCCDatabase(
            this IApplicationBuilder app)
        {
            using (var scope =
              app.ApplicationServices.CreateScope())
            using (var context = scope.ServiceProvider.GetRequiredService<DataContext>())
                context.Database.EnsureCreated();

            return app;
        }
    }
}
