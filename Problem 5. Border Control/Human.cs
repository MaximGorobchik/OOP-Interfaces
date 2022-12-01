using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Border_Control
{
    public class Human : IHumans
    {
        public Human(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.ID_Human = id;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string ID_Human { get; set; }
    }
}
