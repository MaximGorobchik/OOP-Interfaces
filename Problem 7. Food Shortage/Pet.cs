﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Food_Shortage
{
    public class Pet : IPet
    {
        public Pet(string name, string birhday)
        {
            this.Name = name;
            this.Birthday_Pet = birhday;
        }
        public string Name { get; set; }
        public string Birthday_Pet { get; set; }
    }
}
