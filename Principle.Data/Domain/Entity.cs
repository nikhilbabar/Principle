using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principle.Data
{
    [Table("Entity")]
    public class Entity
    {
        [Column("EntityId")]
        public int Id { get; set; }
        [Required]
        [Column("EntityName")]
        public string Name { get; set; }
        public int EntityTypeId { get; set; }
        public bool IsValid { get; set; }
        public virtual EntityType EntityType { get; set; }
    }
}
