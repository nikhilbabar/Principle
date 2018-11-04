using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principle.Models.ReadModels
{
    public class RecommendationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<SuggestionModel> Suggestions { get; set; }
        public class SuggestionModel
        {
            public string Name { get; set; }
            public sbyte Priority { get; set; }
        }
    }
}
