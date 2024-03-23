using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Polymorphism
{
    public class Animal
    {
        public virtual void Makesound()
        {
            Console.WriteLine("This is base class of Animal Sound: All animals make sound ");
        }
    }
}
