using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Animal dog = new Dog();
            Animal lion = new Lion();

            animal.Makesound();
            dog.Makesound();
            lion.Makesound();

            Console.ReadKey();
        }
    }
}
