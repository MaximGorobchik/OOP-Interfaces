using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Military_Elite
{
    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public LeutenantGeneral(string id, string firstname, string lastname, double salary) : base(id,firstname, lastname, salary)
        {
            this.Privates = new List<IPrivate>();
        }
        public IList<IPrivate> Privates { get; }
        public override string ToString()
        {
            return $"{base.ToString()} \nPrivates: \n {string.Join(Environment.NewLine + " ", this.Privates)}";
        }
    }
}
