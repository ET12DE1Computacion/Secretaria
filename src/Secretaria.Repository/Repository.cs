using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Secretaria.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        internal readonly DbContext context;

        public Repository(DbContext context)
        {
            this.context = context;
        }

        public virtual void Insert (T id)
        {
            this.context.Add(id);
        }

        public virtual void Delete(T id)
        {
            this.context.Set<T>().Remove(id);
        }

        // Check
        public virtual IEnumerable<T> GetAll( Expression<Func<T, bool>> condition, 
                                              Func<IQueryable<T>, IOrderedQueryable<T>> orderBy)
        {
            return orderBy(this.context.Set<T>().Where(condition));
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> condition)
        {
            return this.context.Set<T>().Where(condition);
        }

        public T Get(T id)
        {
            return this.context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetTs()
        {
            return context.Set<T>().ToList();
        }

    }
}
