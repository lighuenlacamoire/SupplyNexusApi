using ECommerce.Domain.Entities;
using ECommerce.Domain.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.ORM
{
    public class DataContext : DbContext
    {
        public DataContext(
            DbContextOptions<DataContext> options) : base(options)
        {
            //Database.Migrate();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TiendaEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoEntityConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Tienda> Tiendas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}
