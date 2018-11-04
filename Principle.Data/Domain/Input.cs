using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principle.Data
{
    [Table("Input")]
    public class Input
    {
        [Column("InputId")]
        public int Id { get; set; }
        [Required]
        [Column("InputName")]
        public string Name { get; set; }
    }
}
