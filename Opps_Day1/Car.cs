using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Day1
{
    public class Car
    {
        public int _sum;

        public Car(int sum)
        {
            _sum = sum;
        }


        public void display()
        {
            Console.WriteLine(_sum);
        }

    }
}
