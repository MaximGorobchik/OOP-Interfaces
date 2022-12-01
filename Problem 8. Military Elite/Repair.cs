using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Military_Elite
{
    public class Repair : IRepair
    {
        public Repair(string partname, int workedhours) 
        { 
            this.PartName = partname;
            this.WorkedHours = workedhours;
        }
        public string PartName { get; }
        public int WorkedHours { get; }
        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hourse Worked: {this.WorkedHours}";
        }
    }
}
