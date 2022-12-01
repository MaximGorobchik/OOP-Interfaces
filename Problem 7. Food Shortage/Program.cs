using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Food_Shortage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var humans = new List<Human>();
            var rebels = new List<Rebel>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var inputline = Console.ReadLine().Split();
                if (inputline.Length == 4)
                {
                    humans.Add(new Human(inputline[0], int.Parse(inputline[1]), inputline[2], inputline[3]));
                }
                else if (inputline.Length == 3)
                {
                    rebels.Add(new Rebel(inputline[0], int.Parse(inputline[1]), inputline[2]));
                }
            }
            var humans_or_rebels_name = Console.ReadLine();
            while (!humans_or_rebels_name.Equals("End"))
            {
                AddFood(humans_or_rebels_name, humans, rebels);
                humans_or_rebels_name= Console.ReadLine();
            }
            Console.WriteLine(humans.Sum(x => x.Food) + rebels.Sum(x => x.Food));
        }
        private static void AddFood(string name, List<Human> list1, List<Rebel> list2)
        {
            if (list1.Any(x => x.Name == name))
            {
                list1.First(x => x.Name == name).BuyFood();
            }
            if (list2.Any(x => x.Name == name))
            {
                list2.First(x => x.Name == name).BuyFood();
            }
        }
    }
}
