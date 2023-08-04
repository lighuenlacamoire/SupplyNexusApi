using ECommerce.Domain.DTOs;
using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.ORM;
using ECommerce.Services.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services.Implements
{
    public class TiendaService : ITiendaService
    {
        #region Dependencias
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region Constructor
        public TiendaService(
            IUnitOfWork unitOfWork
            )
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Metodos
        public List<EntregaDTO> GetAllEntregas()
        {
            var pedidos = _unitOfWork.Pedidos.GetAll();

            var tiendas = pedidos
                .GroupBy(x => new { 
                    x.Tienda,
                    x.FechaDeEntrega
                })
                .Select(y => new EntregaDTO
                {
                    TiendaNombre = y.Key.Tienda.Nombre,
                    FechaEntrega = y.Key.FechaDeEntrega,
                    CantPedidos = y.Count(),
                })
                .OrderBy(z => z.FechaEntrega)
                .ThenBy(z => z.TiendaNombre)
                .ToList();

            return tiendas;
        }

        #endregion
    }
}
