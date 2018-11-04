using Principle.Models.ReadModels;
using System.Collections.Generic;

namespace Principle.Services.Recommendation
{
    public interface IRecommendationLogic
    {
        List<RecommendationModel> FindRecommendation(List<WildSearchModel> inputColletion, List<WildSearchModel> masterCollection);
    }
}
