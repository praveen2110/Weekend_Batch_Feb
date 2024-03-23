using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Polymorphism
{
    public class Dog : Animal
    {
        public override void Makesound()
        {
            Console.WriteLine("The dog Barks");
        }
    }
}
