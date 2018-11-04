using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principle.Data
{
    [Table("EntityType")]
    public class EntityType
    {
        [Column("EntityTypeId")]
        public int Id { get; set; }
        [Required]
        [Column("EntityTypeName")]
        public string Name { get; set; }
        public virtual List<Entity> Entities { get; set; }
    }
}
