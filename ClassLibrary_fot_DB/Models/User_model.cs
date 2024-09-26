using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_fot_DB.Models
{
    public class User_model
    {
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public int Age { get; set; }
        public int Score { get; set; }
        public User_model(string first_name, string last_name, int age, int score)
        {
            First_name = first_name;
            Last_name = last_name;
            Age = age;
            Score = score;
        }
        public override string ToString()
        {
            return $"{Last_name,15} {First_name,15} {Age,5} {Score,15}";
        }
    }
}
