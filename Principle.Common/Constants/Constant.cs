namespace Principle.Common.Constants
{
    public static class ProgramConstant
    {
        public const int MajorTolerance = 3;
        public const int Tolerance = 2;
        public const int MinorTolerance = 1;
    }

    public static class RegExpression
    {
        public const string PresentWhiteSpaceExpression = @"\s+";
    }

    public static class CharacterLiteral
    {
        public const string WhiteSpace = @"\s";
    }

    public static class Template
    {
        public const string MockEntityService = "Principle.Services.Entity.MockEntityService";
        public const string DataEntityService = "Principle.Services.Entity.DataEntityService";
        public const string RecommendationAsyncLogic = "Principle.Services.Recommendation.RecommendationAsyncLogic";
        public const string RecommendationSyncLogic = "Principle.Services.Recommendation.RecommendationSyncLogic";
    }

}
