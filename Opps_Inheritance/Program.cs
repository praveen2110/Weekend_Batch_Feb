using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA objA = new ClassA();
            ClassB objB = new ClassB();

            objA.A = 20;
            objA.B = 20;

            Console.WriteLine(objB.sum());
            Console.WriteLine(objB.Diff());

            Console.ReadKey();
            
        }
    }
}
