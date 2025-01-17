﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_fot_DB.Models
{
    public class Question_model
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public int TypeId { get; set; }
        public Question_model(string title, int categoryId, int typeId)
        {
            Title = title;
            CategoryId = categoryId;
            TypeId = typeId;
        }
        public override string ToString()
        {
            return $"{Title,15} {CategoryId, 10} {TypeId, 10}";
        }
    }
}
