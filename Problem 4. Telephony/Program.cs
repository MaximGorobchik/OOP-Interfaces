using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Telephony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = Console.ReadLine().Split();
                var webs = Console.ReadLine().Split();
                Smartphone smartphone = new Smartphone();
                foreach (var numbers in number)
                {
                    Console.WriteLine(smartphone.CallOtherPhones(numbers));
                }
                foreach (var web in webs)
                {
                    Console.WriteLine(smartphone.BrowsingWeb(web));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
