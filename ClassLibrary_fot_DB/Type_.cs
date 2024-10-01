using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_fot_DB
{
    [Table(name: "Types")]
    public class Type_
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
