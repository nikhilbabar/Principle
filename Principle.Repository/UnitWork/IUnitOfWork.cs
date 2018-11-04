using System.Collections.Generic;
using System.Data.Entity.Core.Objects;

namespace Principle.Repository
{
    public interface IUnitOfWork
    {
        GenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class;

        IEnumerable<TEntity> SQLQuery<TEntity>(string sql, params object[] parameters);

        ObjectResult<TEntity> ExecuteFunction<TEntity>(string functionName, params ObjectParameter[] parameters);

        bool Save();
    }
}
