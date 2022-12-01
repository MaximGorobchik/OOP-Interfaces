using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Military_Elite
{
    public class Private : Soldier, IPrivate
    {
        public Private(string id, string firstname, string lastname, double salary) : base (id,firstname,lastname)
        {
            this.Salary = salary;
        }

        public double Salary { get; }
        public override string ToString()
        {
            return $"Name: {this.Soldier_FirstName} {this.Soldier_LastName} Id: {Soldier_ID} Salary: {this.Salary}";
        }
    }
}
