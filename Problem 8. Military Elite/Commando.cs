using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Military_Elite
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstname, string lastname, double salary, string corps) : base (id,firstname,lastname, salary, corps)
        {
            this.Missions = new List<IMissions>();
        }
        public IList<IMissions> Missions { get; }
        public override string ToString()
        {
            return $"{base.ToString()} \nMissions: \n {string.Join(Environment.NewLine, this.Missions)}".Trim();
        }
    }
}
