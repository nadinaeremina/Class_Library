using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_fot_DB.Models
{
    public class Category_model
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public Category_model(string title)
        {
            Title = title;
        }
        public override string ToString()
        {
            return $"{Title,15}";
        }
    }
}
