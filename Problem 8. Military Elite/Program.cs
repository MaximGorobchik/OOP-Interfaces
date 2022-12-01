using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Military_Elite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ISoldier> soldiers = new List<ISoldier>();
            var inputline = Console.ReadLine();
            while(!inputline.Equals("End"))
            {
                Check(inputline, soldiers);
                inputline = Console.ReadLine();
            }
            foreach (var x in soldiers)
            {
                Console.WriteLine(x);
            }
        }  
        private static IList<IMissions> TakeMission(List<string> restOfTokens)
        {
            var allMissions = new List<IMissions>();
            for (int i = 0; i < restOfTokens.Count() - 1; i += 2)
            {
                var code = restOfTokens[i];
                var state = restOfTokens[i + 1];

                if (state != "inProgress" && state != "Finished") continue;

                allMissions.Add(new Mission(code, state));
            }

            return allMissions;
        }
        private static IList<IRepair> TakeRepairs(IList<string> restOfTokens)
        {
            var allRepairs = new List<IRepair>();
            for (int i = 0; i < restOfTokens.Count() - 1; i += 2)
            {
                var part = restOfTokens[i];
                var hour = int.Parse(restOfTokens[i + 1]);
                allRepairs.Add(new Repair(part, hour));
            }

            return allRepairs;
        }
        private static List<IPrivate> GetPrivates(IEnumerable<string> privateIds, List<ISoldier> allPrivates)
        {
            var list = new List<IPrivate>();
            foreach (var id in privateIds)
            {
                if (allPrivates.Any(x => x.Soldier_ID == id))
                {
                    list.Add((IPrivate)allPrivates.First(x => x.Soldier_ID == id));
                }
            }

            return list;
        }
        private static void Check(string text, List<ISoldier> soldiers)
        {
                var info = text.Split();
                if (info[0].Equals("Private"))
                {
                    soldiers.Add(new Private(info[1], info[2], info[3], double.Parse(info[4])));
                    return;
                }
                if (info[0].Equals("Commando"))
                {
                    var c = new Commando(info[1], info[2], info[3], double.Parse(info[4]), info[5]);
                    var rest = info.Skip(6).ToList();
                    var mission = TakeMission(rest);
                    foreach (var x in mission)
                    {
                        c.Missions.Add(x);
                    }
                    soldiers.Add(c);
                    return;
                }
                if (info[0].Equals("Engineer"))
                {
                    var e = new Engineer(info[1], info[2], info[3], double.Parse(info[4]), info[5]);
                    var rest = info.Skip(6).ToList();
                    var repair = TakeRepairs(rest);
                    foreach (var x in repair)
                    {
                        e.Repairs.Add(x);
                    }
                    soldiers.Add(e);
                    return;
                }
                if (info[0].Equals("LeutenantGeneral"))
                {
                    var l = new LeutenantGeneral(info[1], info[2], info[3], double.Parse(info[4]));
                    var Private_ID = info.Skip(5);
                    var Private = GetPrivates(Private_ID, soldiers);
                    foreach (var x in Private)
                    {
                        l.Privates.Add(x);
                    }
                    soldiers.Add(l);
                    return;
                }
                soldiers.Add(new Spy(info[1], info[2], info[3], info[4]));
        }
    }
}
