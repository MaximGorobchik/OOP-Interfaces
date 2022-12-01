using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Military_Elite
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer (string id, string firstname, string lastname, double salary, string crops) : base (id,firstname,lastname, salary, crops)
        {
            this.Repairs = new List<IRepair>();
        }
        public IList<IRepair> Repairs { get; }
        public override string ToString()
        {
            return $"{base.ToString()} \nReparis: \n {string.Join(Environment.NewLine, this.Repairs)}";
        }
    }
}
