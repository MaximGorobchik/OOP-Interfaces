using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Birthday_Celebrations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var humans = new List<Human>();
            var robots = new List<Robot>();
            var pets = new List<Pet>();
            string inputline = Console.ReadLine();
            while (!inputline.Equals("End"))
            {
                var info = inputline.Split();
                if (info[0].Equals("Citizen"))
                {
                    humans.Add(new Human(info[1], int.Parse(info[2]), info[3], info[4]));
                }
                else if (info[0].Equals("Robot"))
                {
                    robots.Add(new Robot(info[1], info[2]));
                }
                else if (info[0].Equals("Pet"))
                {
                    pets.Add(new Pet(info[1], info[2]));
                }
                inputline = Console.ReadLine();
            }
            var year = Console.ReadLine();
            var detained_year = humans.Where(x => x.Birthday_Human.EndsWith(year)).Select(x => x.Birthday_Human).ToList().Concat(pets.Where(x => x.Birthday_Pet.EndsWith(year)).Select(x =>x.Birthday_Pet)).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, detained_year));
        }
    }
}
