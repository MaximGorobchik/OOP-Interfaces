using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Military_Elite
{
    public interface IMissions
    {
        string CodeName { get; }
        string State { get; set; }
        void CompleteMission();
    }
}
