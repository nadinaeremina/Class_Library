using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_fot_DB
{
    [Table(name: "Answer_masses")]
    public class Answer_mas
    {
        [Key]
        public int ID { get; set; }
        public Question Question { get; set; }
    }
}
