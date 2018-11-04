using Principle.Models.ReadModels;
using System.Collections.Generic;
using Principle.Models.Enums;

namespace Principle.Services.Recommendation
{
    public interface IRecommendationService
    {
        List<RecommendationModel> GetRecommendation(SizeType type, List<WildSearchModel> collection);
    }
}
