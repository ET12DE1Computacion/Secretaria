using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Query;

namespace Secretaria.Repository
{
    public interface IRepository<T> where T : class
    {
        void Insert(T id);
        void Delete(T id);
        T Get(T id);
        IEnumerable<T> GetTs();

        // Check
        IEnumerable<T> GetAll(Expression<Func<T, bool>> condition,
                                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy);

        IEnumerable<T> GetAll(Func<IQueryable<T>, IIncludableQueryable<T, object>> include);

        IEnumerable<T> GetAll(Expression<Func<T, bool>> condition,
                                Func<IQueryable<T>, IIncludableQueryable<T, object>> include,
                                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy);
        IEnumerable<T> Find(Expression<Func<T, bool>> condition);

        T GetOne(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
    }
}
