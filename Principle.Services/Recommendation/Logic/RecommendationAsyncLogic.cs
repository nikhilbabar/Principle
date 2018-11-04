using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Principle.Models.ReadModels;
using Principle.Common.Utilities;
using Principle.Models.Enums;

namespace Principle.Services.Recommendation
{
    class RecommendationAsyncLogic : IRecommendationLogic
    {
        public List<RecommendationModel> FindRecommendation(List<WildSearchModel> inputColletion, List<WildSearchModel> masterCollection)
        {
            List<SuggestionModel> suggestions = new List<SuggestionModel>();
            var distance = 0;
            var priority = Priority.P3;
            Parallel.ForEach(inputColletion.AsEnumerable(), (inputentity) =>
            {
                var items = (from materentity in masterCollection
                             where StringOperationUtility.StringToStringCompare(inputentity.Name, materentity.Name, false, out priority)
                             select new SuggestionModel
                             {
                                 EntityId = inputentity.Id,
                                 EntityName = inputentity.Name,
                                 SuggestedEntityName = materentity.Name,
                                 SuggestedEntityPriority = priority,
                                 Distance = distance
                             }).Distinct().OrderBy(x => x.EntityId).ThenBy(x => x.SuggestedEntityPriority).ThenBy(x => x.Distance).Take(10);
                suggestions.AddRange(items);
            });

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
