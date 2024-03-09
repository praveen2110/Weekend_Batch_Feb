using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Inheritance
{
    class ClassB : ClassA
    {
       
        
        public int Diff()
        {            
            int diff = A - B;            
            return diff;
        }
        
    }
}
