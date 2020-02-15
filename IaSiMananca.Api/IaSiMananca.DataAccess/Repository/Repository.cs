using IaSiMananca.DataAccess.Context;
using IaSiMananca.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace IaSiMananca.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private AppDbContext _dbContext;

        public Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(T entity)
        {
            _dbContext.Set<T>().Add(entity);
        }

        public IEnumerable<T> Filter(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Where(predicate);
        }
      
        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }

        public T GetById(Guid id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
