using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Military_Elite
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        protected SpecialisedSoldier(string id, string firstname, string lastname, double salary, string crops) : base (id,firstname,lastname,salary)
        {
            this.Crops= crops;
        }
        public string Crops { get; }
        public override string ToString()
        {
            return $"{base.ToString()}\nCorps: {this.Crops}\n";
        }
    }
}
