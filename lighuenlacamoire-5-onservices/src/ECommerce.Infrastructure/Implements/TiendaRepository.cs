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
    public class TiendaRepository : BaseRepository<Tienda>,
        ITiendaRepository,
        IBaseRepository<Tienda>
    {
        #region Constructor
        public TiendaRepository(
            DataContext context) : base(context)
        {
        }
        #endregion

        public List<Tienda> GetAll()
        {
            return _dbContext.Tiendas
                .ToList();
        }
    }
}
