using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_fot_DB.Models
{
    public class Answer_model
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public bool IsRight { get; set; }
        public int Answer_masId { get; set; }
        public Answer_model(string title, bool isRight, int answer_masId)
        {
            Title = title;
            IsRight = isRight;
            Answer_masId = answer_masId;
        }
        public override string ToString()
        {
            return $"{Title,15} {IsRight, 5} {Answer_masId}";
        }
    }
}
