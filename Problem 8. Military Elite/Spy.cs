using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Military_Elite
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstname, string lastname, string codeNumber) : base (id,firstname,lastname)
        {
            this.NumberCode= codeNumber;
        }
        public string NumberCode { get; }
        public override string ToString()
        {
            return $"{base.ToString()} \nCode Number: {this.NumberCode}";
        }
    }
}
