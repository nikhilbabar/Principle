using System;
using System.Collections.Generic;
using Principle.Models.ReadModels;
using Principle.Repository;

namespace Principle.Services.Entity
{
    public class MockEntityService : IRetrieveEntityService
    {

        #region Declaration(s)
        private readonly MockEntityRepository repository;
        #endregion

        #region Properties
        public MockEntityService()
        {
            repository = new MockEntityRepository();
        }
        #endregion

        #region Constructor(s)
        #endregion

        #region Method(s)
        public List<WildSearchModel> GetMasterEntities()
        {
            return repository.MasterEntities;
        }

        public List<WildSearchModel> GetNewEntities()
        {
            return repository.NewEntities;
        }
        #endregion

        #region Function(s)
        #endregion

    }
}
