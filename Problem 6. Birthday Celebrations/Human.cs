using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Birthday_Celebrations
{
    public class Human : IHumans
    {
        public Human(string name, int age, string id, string birthday_Human)
        {
            this.Name = name;
            this.Age = age;
            this.ID_Human = id;
            Birthday_Human = birthday_Human;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string ID_Human { get; set; }
        public string Birthday_Human { get; set; }
    }
}
