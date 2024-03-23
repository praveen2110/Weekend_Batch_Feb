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
            ClassB ObjB = new ClassB();

            //objA.A = 20;
            //objA.B = 20;

            Console.WriteLine(objA.sum(30));
            Console.WriteLine(ObjB.Diff());
            //Console.WriteLine(objA.sum(30.123));

            Console.ReadKey();
            
        }
    }
}
