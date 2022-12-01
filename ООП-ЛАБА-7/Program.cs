using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_ЛАБА_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();
            IBirthable birtdate = new Citizen(name, age, birthdate, id);
            IIdentifiable Id = new Citizen(name, age, birthdate, id);
            IPerson person = new Citizen(name, age,birthdate,id);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(birtdate.Birthdate);
            Console.WriteLine(Id.ID);
        }
    }
}
