using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Day1
{
    class Program
    {        
        static void Main(string[] args)
        {
            //Class name object name = new ConstructorName();
            Car obj = new Car(20); //Compiler will create default 

            
            //obj.sum = 20;
            obj.display();
            //Console.WriteLine(obj.sum);

            Car obj2 = new Car(30); //Compiler will create default 
            obj2.display();
            Console.ReadKey();
        }
    }
}
