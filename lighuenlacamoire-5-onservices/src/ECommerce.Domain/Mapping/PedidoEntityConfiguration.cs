using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Entities;

namespace ECommerce.Domain.Mapping
{
    public class PedidoEntityConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {

            builder
                .HasOne(p => p.Tienda)
                .WithMany()
                .HasForeignKey(fk => fk.TiendaId)
                .HasPrincipalKey(fk => fk.Id);

            builder
                .HasData(
                new Pedido
                {
                    Id = 1,
                    TiendaId = 4,
                    ShipmentId = "12345678",
                    FechaDeEntrega = new DateTime(year: 2022, month: 05, day: 23),
                    EstadoMayor = 700,
                    EstadoMenor = 650
                },
                new Pedido
                {
                    Id = 2,
                    TiendaId = 2,
                    ShipmentId = "87654321",
                    FechaDeEntrega = new DateTime(year: 2022, month: 05, day: 16),
                    EstadoMayor = 600,
                    EstadoMenor = 650
                },
                new Pedido
                {
                    Id = 3,
                    TiendaId = 1,
                    ShipmentId = "01593657",
                    FechaDeEntrega = new DateTime(year: 2022, month: 05, day: 23),
                    EstadoMayor = 650,
                    EstadoMenor = 650
                },
                new Pedido
                {
                    Id = 4,
                    TiendaId = 1,
                    ShipmentId = "15935746",
                    FechaDeEntrega = new DateTime(year: 2022, month: 05, day: 15),
                    EstadoMayor = 300,
                    EstadoMenor = 600
                },
                new Pedido
                {
                    Id = 5,
                    TiendaId = 2,
                    ShipmentId = "87555321",
                    FechaDeEntrega = new DateTime(year: 2022, month: 05, day: 13),
                    EstadoMayor = 400,
                    EstadoMenor = 450
                },
                new Pedido
                {
                    Id = 6,
                    TiendaId = 2,
                    ShipmentId = "12355321",
                    FechaDeEntrega = new DateTime(year: 2022, month: 05, day: 13),
                    EstadoMayor = 200,
                    EstadoMenor = 750
                },
                new Pedido
                {
                    Id = 7,
                    TiendaId = 1,
                    ShipmentId = "82399321",
                    FechaDeEntrega = new DateTime(year: 2022, month: 05, day: 15),
                    EstadoMayor = 500,
                    EstadoMenor = 500
                }
                );
        }
    }
}
