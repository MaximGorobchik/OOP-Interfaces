using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Military_Elite
{
    interface ISpecialisedSoldier : IPrivate
    {
        string Crops { get; }
    }
}
