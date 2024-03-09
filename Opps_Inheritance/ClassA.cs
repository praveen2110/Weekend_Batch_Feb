using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Inheritance
{
    public class ClassA 
    {
        private int a;
        private int b;

        public int A 
        {
            get;set;
        }

        public int B
        {
            get;set;
        }



        public int sum()
        {
            int sum = A + B;
            return sum;
        }
    }
}
