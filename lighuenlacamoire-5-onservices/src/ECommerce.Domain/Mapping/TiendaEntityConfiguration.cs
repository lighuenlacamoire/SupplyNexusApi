using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Mapping
{
    public class TiendaEntityConfiguration : IEntityTypeConfiguration<Tienda>
    {
        public void Configure(EntityTypeBuilder<Tienda> builder)
        {

            builder
                .HasData(
                new Tienda { Id = 1, Nombre = "Ciudad Imagen", Enabled = true },
                new Tienda { Id = 2, Nombre = "Alcobendas", Enabled = true },
                new Tienda { Id = 3, Nombre = "El Pinar", Enabled = true },
                new Tienda { Id = 4, Nombre = "Cuenca", Enabled = true }
            );
        }
    }
}
