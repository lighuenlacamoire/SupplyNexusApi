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
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {
        #region Dependencias
        protected readonly DataContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;
        #endregion

        #region Constructor
        public BaseRepository(DataContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<TEntity>();
        }
        #endregion

        #region Metodos
        public IQueryable<TEntity> GetQueryable()
        {
            return _dbSet.AsNoTracking();
        }
        #endregion
    }
}
