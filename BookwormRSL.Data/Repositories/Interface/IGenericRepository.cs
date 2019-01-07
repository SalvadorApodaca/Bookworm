using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookwormRSL.Data.Repositories.Interface
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            params Expression<Func<TEntity, object>>[] includes);

        TEntity GetById(int Id);

        Task<TEntity> GetByIdAsync(int Id);

        void Insert(TEntity obj);

        void Update(TEntity obj);

        void Delete(TEntity obj);
    }
}
