using Principle.Models.ReadModels;
using System.Collections.Generic;

namespace Principle.Services.Entity
{
    public interface IRetrieveEntityService
    {
        List<WildSearchModel> GetMasterEntities();
        List<WildSearchModel> GetNewEntities();

    }
}
