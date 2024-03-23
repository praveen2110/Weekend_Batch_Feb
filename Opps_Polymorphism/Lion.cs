using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Polymorphism
{
    public class  Lion : Animal
    {
        public override void Makesound()
        {
            base.Makesound();
            Console.WriteLine("The Lion Roars");
        }
    }
}
