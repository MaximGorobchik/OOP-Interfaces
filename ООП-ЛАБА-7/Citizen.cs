using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_ЛАБА_7
{
    public class Citizen : IPerson, IIdentifiable, IBirthable
    {
        public Citizen(string name, int age, string birthdate, string iD)
        {
            this.Name = name;
            this.Age = age;
            this.Birthdate = birthdate;
            this.ID = iD;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Birthdate { get; set; }
        public string ID { get; set; }
    }
}
