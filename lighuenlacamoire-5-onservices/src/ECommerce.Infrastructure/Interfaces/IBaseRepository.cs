using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetQueryable();
    }
}
