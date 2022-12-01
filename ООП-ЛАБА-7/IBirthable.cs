using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_ЛАБА_7
{
    public interface IBirthable : IIdentifiable
    {
        string Birthdate { get; set; }
    }
}
