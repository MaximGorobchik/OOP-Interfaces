using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Food_Shortage
{
    interface IBuyer
    {
        void BuyFood();
        int Food { get; set; }
    }
}
