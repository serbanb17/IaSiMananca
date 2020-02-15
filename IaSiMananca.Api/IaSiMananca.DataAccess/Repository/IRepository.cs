using IaSiMananca.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace IaSiMananca.DataAccess.Repository
{
    public interface IRepository<T> where T : EntityBase
    {
        void Create(T entity);

        T GetById(Guid id);

        IEnumerable<T> Filter(Expression<Func<T, bool>> predicate);

        IEnumerable<T> GetAll();

        void Update(T entity);

        void Delete(T entity);

        void Save();
    }
}
