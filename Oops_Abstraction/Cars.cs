using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Abstraction
{
    public abstract class Cars
    {
        public abstract double price();
        public abstract int gettotalseat();
        public abstract string colors();

        public string wheel()
        {
            return "4 Wheels";
        }
        public string CheckAC()
        {
            return "AC is available";
        }
        public string Music()
        {
            return "Music system not available";
        }
    }
}
