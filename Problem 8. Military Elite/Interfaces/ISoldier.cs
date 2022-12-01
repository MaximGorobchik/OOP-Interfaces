using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Military_Elite
{
    public interface ISoldier
    {
        string Soldier_ID { get; }
        string Soldier_FirstName { get; }
        string Soldier_LastName { get; }
    }
}
