using Principle.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Principle.Repository
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        internal PrincipleDataContext _dataContext;
        internal DbSet<TEntity> _dbSet;

        public GenericRepository(PrincipleDataContext context)
        {
            _dataContext = context;
            _dbSet = context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetQueryable()
        {
            return _dbSet.AsNoTracking();
        }

        public IQueryable<TEntity> GetQueryable<TProperty>(Expression<Func<TEntity, TProperty>> path)
        {
            return _dbSet.Include(path).AsNoTracking();
        }

        public IQueryable<TEntity> GetQueryableWithTrackingEnabled<TProperty>(Expression<Func<TEntity, TProperty>> path)
        {
            return _dbSet.Include(path);
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            return orderBy != null ? orderBy(query).ToList() : query.ToList();
        }

        public virtual TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual TEntity GetFirstOrDefault(Expression<Func<TEntity, bool>> filter = null)
        {
            return null != filter ? _dbSet.FirstOrDefault(filter) : _dbSet.FirstOrDefault();
        }

        public virtual TEntity Insert(TEntity entity)
        {
            return _dbSet.Add(entity);
        }

        public virtual IEnumerable<TEntity> InsertRange(IEnumerable<TEntity> entities)
        {
            return _dbSet.AddRange(entities);
        }

        public virtual TEntity Delete(object id)
        {
            TEntity entityToDelete = _dbSet.Find(id);
            return Delete(entityToDelete);
        }

        public virtual TEntity Delete(TEntity entityToDelete)
        {
            return _dbSet.Remove(entityToDelete);
        }

        public virtual IEnumerable<TEntity> DeleteRange(IEnumerable<TEntity> entitiesToDelete)
        {
            return _dbSet.RemoveRange(entitiesToDelete);
        }

        public virtual void Delete(Expression<Func<TEntity, bool>> filter)
        {
            var entities = _dbSet.Where(filter).AsEnumerable();
            foreach (var entity in entities)
            {
                _dbSet.Remove(entity);
            }
        }

        public virtual TEntity Update(TEntity entityToUpdate)
        {
            var entity = _dbSet.Attach(entityToUpdate);
            _dataContext.Entry(entityToUpdate).State = EntityState.Modified;
            return entity;
        }
    }
}
