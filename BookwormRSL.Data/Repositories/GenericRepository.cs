using BookwormRSL.Data.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookwormRSL.Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private BookwormDbContext _context = null;
        private DbSet<TEntity> table = null;

        public GenericRepository()
        {
            _context = new BookwormDbContext();
            table = _context.Set<TEntity>();
        }

        public GenericRepository(BookwormDbContext context)
        {
            _context = context;
            table = _context.Set<TEntity>();
        }

        public void Delete(TEntity obj)
        {
            table.Remove(obj);
        }

        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = table;

            foreach(Expression<Func<TEntity, object>> include in includes)
            {
                query.Include(include);
            }

            if(!(filter is null))
            {
                query = query.Where(filter);
            }

            if(!(orderBy is null))
            {
                query = orderBy(query);
            }

            return query;
        }

        public TEntity GetById(int Id)
        {
            return table.Find(Id);
        }

        public Task<TEntity> GetByIdAsync(int Id)
        {
            return table.FindAsync(Id);
        }

        public void Insert(TEntity obj)
        {
            table.Add(obj);
        }

        public void Update(TEntity obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
    }
}
