using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Birthday_Celebrations
{
    interface IHumans
    {
        string Name { get; set; }
        int Age { get; set; }
        string ID_Human { get; set; }
        string Birthday_Human { get; set; } 
    }
}
