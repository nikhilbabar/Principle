using Principle.Models.Enums;
using Principle.Models.ReadModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principle.Models.CommandModels
{
    public class RecommendationCommandModel
    {
        [Required(ErrorMessage = "Type is required field.")]
        [Range((int)SizeType.Small, (int)SizeType.Large, ErrorMessage = "Range should be in between 1 and 2.")]
        public SizeType Type { get; set; }

        [Required(ErrorMessage = "Collection is required field.")]
        public List<WildSearchModel> Collection { get; set; }
    }
}
