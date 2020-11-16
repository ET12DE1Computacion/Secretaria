using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Secretaria.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        internal readonly DbContext context;

        public Repository(DbContext context)
        {
            this.context = context;
        }

        public virtual void Insert(T id)
        {
            this.context.Add(id);
        }

        public virtual void Delete(T id)
        {
            this.context.Set<T>().Remove(id);
        }

        // Check
        public virtual IEnumerable<T> GetAll(Expression<Func<T, bool>> condition,
                                              Func<IQueryable<T>, IOrderedQueryable<T>> orderBy)
        {
            return orderBy(this.context.Set<T>().Where(condition));
        }

        public virtual T GetOne(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> result = context.Set<T>().Where(predicate);

            if (include != null)
                result = include(result);

            return result.FirstOrDefault();
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

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> condition, Func<IQueryable<T>, IIncludableQueryable<T, object>> include, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy)
        {
            IQueryable<T> result = context.Set<T>().Where(condition);

            if (include != null)
                result = include(result);

            return result.ToList();

        }

        public IEnumerable<T> GetAll(Func<IQueryable<T>, IIncludableQueryable<T, object>> include)
        {
            IQueryable<T> result = context.Set<T>();

            if (include != null)
                result = include(result);

            return result.ToList();
        }
    }
}
