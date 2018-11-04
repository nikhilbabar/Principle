namespace Principle.Models.ReadModels
{
    using Principle.Models.Enums;

    public class SuggestionModel
    {
        public int EntityId { get; set; }
        public string EntityName { get; set; }
        public string SuggestedEntityName { get; set; }
        public Priority SuggestedEntityPriority { get; set; }
        public int Distance { get; set; }
    }
}
