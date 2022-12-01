    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Border_Control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var humans = new List<Human>();
            var robots = new List<Robot>();
            string inputline = Console.ReadLine();
            while (!inputline.Equals("End"))
            {
                var info = inputline.Split();
                if (info.Length == 3)
                {
                    humans.Add(new Human(info[0], int.Parse(info[1]), info[2]));
                }
                else if (info.Length == 2)
                {
                    robots.Add(new Robot(info[0], info[1]));
                }
                inputline = Console.ReadLine();
            }
            var ids = Console.ReadLine();
            var detained_ids = humans.Where(x => x.ID_Human.EndsWith(ids)).Select(x => x.ID_Human).ToList().Concat(robots.Where(x => x.ID_Robot.EndsWith(ids)).Select(x => x.ID_Robot)).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, detained_ids));
        }
    }
}
