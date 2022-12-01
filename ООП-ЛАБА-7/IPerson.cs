using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_ЛАБА_7
{
    public interface IPerson : IBirthable
    {
        string Name { get; set; }
        int Age { get; set; }
    }
}
