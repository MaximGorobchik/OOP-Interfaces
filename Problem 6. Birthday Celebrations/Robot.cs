using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Birthday_Celebrations
{
    public class Robot : IRobots
    {
        public Robot(string model, string ID)
        {
            this.Model= model;
            this.ID_Robot= ID;
        }
        public string Model { get; set; }
        public string ID_Robot { get; set; }
    }
}
