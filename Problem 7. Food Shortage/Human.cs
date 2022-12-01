using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Food_Shortage
{
    public class Human : IHumans, IBuyer
    {
        public Human(string name, int age, string id, string birthday_Human)
        {
            this.Name = name;
            this.Age = age;
            this.ID_Human = id;
            Birthday_Human = birthday_Human;
            this.Food = 0;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string ID_Human { get; set; }
        public string Birthday_Human { get; set; }
        public int Food { get; set; }
        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
