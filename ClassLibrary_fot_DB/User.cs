using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_fot_DB
{
    [Table(name: "Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string First_name { get; set; }
        [Required]
        public string Last_name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int Score { get; set; }
    }
}
