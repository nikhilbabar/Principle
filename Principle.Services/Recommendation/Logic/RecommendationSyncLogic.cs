using System.Collections.Generic;
using System.Linq;
using Principle.Models.ReadModels;
using Principle.Common.Utilities;
using Principle.Models.Enums;

namespace Principle.Services.Recommendation
{
    public class RecommendationSyncLogic : IRecommendationLogic
    {
        public List<RecommendationModel> FindRecommendation(List<WildSearchModel> inputColletion, List<WildSearchModel> masterCollection)
        {
            var priority = Priority.P3;
            var suggestions = (from masterentity in masterCollection
                               from newentity in inputColletion
                               where StringOperationUtility.StringToStringCompare(newentity.Name, masterentity.Name, false, out priority)
                               select new SuggestionModel
                               {
                                   EntityId = newentity.Id,
                                   EntityName = newentity.Name,
                                   SuggestedEntityName = masterentity.Name,
                                   SuggestedEntityPriority = priority,
                               }).Distinct().OrderBy(x => x.EntityId).ThenBy(x => x.SuggestedEntityPriority);

            var recommendations = (from suggestion in suggestions
                                   group suggestion by new
                                   {
                                       suggestion.EntityId,
                                       suggestion.EntityName
                                   } into groupsuggestion
                                   select new RecommendationModel
                                   {
                                       Id = groupsuggestion.Key.EntityId,
                                       Name = groupsuggestion.Key.EntityName,
                                       Suggestions = groupsuggestion.Take(10).Select(x => new RecommendationModel.SuggestionModel { Name = x.SuggestedEntityName, Priority = (sbyte)x.SuggestedEntityPriority }) //string.Join(",", groupsuggestion.Select(x => x.SuggestedEntity))
                                   }).ToList();

            var allEntities = inputColletion.Select(x => x.Name);
            var matchEntities = recommendations.Select(x => x.Name);

            var diff = allEntities.Except(matchEntities);
            var motion = diff.Select(x => new RecommendationModel { Name = x });

            recommendations.AddRange(motion);

            return recommendations;
        }
    }
}
