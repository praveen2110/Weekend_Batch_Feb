using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Inheritance
{
    class ClassB : ClassA
    {
        public int c;
        
        public ClassB() : base()
        {
            c = b;
        }




        public int Diff()
        {
            int diff = a - b + c;
            Console.WriteLine(c);
            return diff;
        }

    }
}
