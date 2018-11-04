using System.ComponentModel.DataAnnotations;

namespace Principle.Models.CommandModels
{
    public class EntityCommandModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int EntityTypeId { get; set; }
        [Required]
        public string EntityTypeName { get; set; }
    }
}
