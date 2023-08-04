using ECommerce.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.ORM
{
    public interface IUnitOfWork
    {

        #region Repositories
        IPedidoRepository Pedidos { get; }
        ITiendaRepository Tiendas { get; }
        #endregion

        #region Transactionals
        void SaveChanges();
        void ChangeTrackerClear();
        #endregion
    }
    public class UnitOfWork : IUnitOfWork
    {
        #region Dependencias
        private readonly DataContext _context;
        public IPedidoRepository Pedidos { get; }
        public ITiendaRepository Tiendas { get; }
        #endregion

        #region Constructor
        public UnitOfWork(
                DataContext context,
                IPedidoRepository pedidoRepository,
                ITiendaRepository tiendaRepository
            )
        {
            this._context = context;
            this.Tiendas = tiendaRepository;
            this.Pedidos = pedidoRepository;
        }
        #endregion

        #region Metodos
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void ChangeTrackerClear()
        {
            _context.ChangeTracker.Clear();
        }
        #endregion
    }
}
