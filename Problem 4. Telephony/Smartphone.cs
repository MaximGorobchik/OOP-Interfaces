using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Telephony
{
    public class Smartphone : ICalling, IBrowsing
    {
        public string BrowsingWeb(string x)
        {
            return x.Any(z => char.IsDigit(z)) ? "Invalid URL!" : $"Browsing: {x}!";
        }
        public string CallOtherPhones(string x)
        {
            return x.Any(z => char.IsDigit(z)) ? $"Calling... {x}" : "Invalid number!";
        }
    }
}
