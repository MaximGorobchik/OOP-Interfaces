using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Ferrari
{
    public interface IFerrari
    {
        string Driver { get; set; }
        string UseBrakes();
        string PushTheGas();
    }
}
