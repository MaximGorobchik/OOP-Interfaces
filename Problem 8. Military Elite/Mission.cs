using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Military_Elite
{
    public class Mission : IMissions
    {
        public Mission(string codeName, string state) 
        {
            this.CodeName = codeName;
            this.State = state;
        }
        public string CodeName { get; }
        public string State { get; set; }
        public void CompleteMission()
        {
            this.State = "Finished";
        }
        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }

    }
}
