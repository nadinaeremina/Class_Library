using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_fot_DB.Models
{
    public class Answer_mas_model
    {
        public int ID { get; set; }
        public int QuestionId { get; set; }
        public Answer_mas_model(string title, int question_d)
        {
            QuestionId = question_d;
        }
        public override string ToString()
        {
            return $"{QuestionId}";
        }
    }
}
