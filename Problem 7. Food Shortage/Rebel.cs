using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Food_Shortage
{
    public class Rebel : IRebel, IBuyer
    {
        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
            this.Food = 0;
        }
        public int Food { get; set; }
        public void BuyFood()
        {
            this.Food += 5;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }

    }
}
