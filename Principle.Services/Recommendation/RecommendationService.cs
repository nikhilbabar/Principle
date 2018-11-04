using System;
using System.Collections.Generic;
using Principle.Repository;
using Principle.Models.ReadModels;
using Principle.Models.Enums;
using Principle.Common.Constants;
using Principle.Common.Factories;
using Principle.Services.Entity;

namespace Principle.Services.Recommendation
{
    public class RecommendationService : IRecommendationService
    {
        #region Declaration(s)
        #endregion

        #region Properties
        #endregion

        #region Constructor(s)
        public RecommendationService()
        {
        }

        #endregion

        #region Method(s)
        public List<RecommendationModel> GetRecommendation(SizeType type, List<WildSearchModel> collection)
        {
            var repositoryTemplate = (type == SizeType.Small) ? Template.MockEntityService : Template.DataEntityService;
            var repository = (IRetrieveEntityService)ServiceObjectFactory.GetObject(repositoryTemplate);

            var masterCollection = repository.GetMasterEntities();

            DateTime startTime = DateTime.Now.ToLocalTime();
            DateTime endTime;

            /// This is the implementation of following principles:
            /// 1. OCP
            /// 2. DIP
            var logicTemplate = (type == SizeType.Small) ? Template.RecommendationSyncLogic : Template.RecommendationAsyncLogic;
            var logic = (IRecommendationLogic)ServiceObjectFactory.GetObject(logicTemplate);
            var recommendations = logic.FindRecommendation(collection, masterCollection);

            endTime = DateTime.Now.ToLocalTime();
            var timeSpan = endTime.Subtract(startTime).Minutes;

            return recommendations;
        }
        #endregion

        #region Function(s)
        #endregion
    }
}
