﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_fot_DB.Models
{
    public class Answer_model
    {
        public string Title { get; set; }
        public Answer_model(string title)
        {
            Title = title;
        }
        public override string ToString()
        {
            return $"{Title,15}";
        }
    }
}