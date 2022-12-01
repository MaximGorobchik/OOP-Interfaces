using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Military_Elite
{
    public abstract class Soldier : ISoldier
    {
        public Soldier(string id, string firstname, string lastname) 
        {
            this.Soldier_ID = id;
            this.Soldier_FirstName = firstname;
            this.Soldier_LastName = lastname;
        }
        public string Soldier_ID { get; }
        public string Soldier_FirstName { get; }
        public string Soldier_LastName { get; }
    }
}
