using Principle.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace Principle.Repository
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly PrincipleDataContext _context = new PrincipleDataContext();
        private bool _disposed;

        public GenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return new GenericRepository<TEntity>(_context);
        }

        public IEnumerable<TEntity> SQLQuery<TEntity>(string sql, params object[] parameters)
        {
            return _context.Database.SqlQuery<TEntity>(sql, parameters);
        }

        public ObjectResult<TEntity> ExecuteFunction<TEntity>(string functionName, params ObjectParameter[] parameters)
        {
            return ((IObjectContextAdapter)this._context).ObjectContext.ExecuteFunction<TEntity>(functionName, parameters);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
                if (disposing)
                    _context.Dispose();
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public bool Save()
        {
            int succussCode = _context.SaveChanges();
            if (succussCode > 0)
                return true;
            else
                return false;
        }
    }
}
