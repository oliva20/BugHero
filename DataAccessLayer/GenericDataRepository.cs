using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer
{
    internal class GenericDataRepository<T> : IGenericDataRepository<T> where T : class
    {
        public virtual void Add(params T[] items)
        {
            throw new NotImplementedException();
        }

        public virtual IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;
            
            throw new NotImplementedException();
        }

        public virtual IList<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public virtual T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(params T[] items)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(params T[] items)
        {
            throw new NotImplementedException();
        }
    }
}