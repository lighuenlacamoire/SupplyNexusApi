using ECommerce.Domain.Entities;
using ECommerce.Infrastructure.Interfaces;
using ECommerce.Infrastructure.ORM;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Implements
{
    public class PedidoRepository : BaseRepository<Pedido>, 
        IPedidoRepository, 
        IBaseRepository<Pedido>
    {
        #region Constructor
        public PedidoRepository(
            DataContext context) : base(context)
        {
        }
        #endregion

        public List<Pedido> GetAll()
        {
            return _dbContext.Pedidos
                .Include(x => x.Tienda)
                .ToList();
        }
    }
}
