using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Ferrari
{
    public class Ferrari : IFerrari
    {
        public Ferrari (string driver)
        {
            this.Driver = driver;
        }
        public string Driver { get; set; }
        public string UseBrakes()
        {
            return "Brakes!";
        }
        public string PushTheGas()
        {
            return "Gaaaaas!";
        }
        public override string ToString()
        {
            return $"488-Spider/{UseBrakes()}/{PushTheGas()}/{this.Driver}";
        }
    }
}
