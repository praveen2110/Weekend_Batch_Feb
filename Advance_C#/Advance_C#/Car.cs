using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_
{
    public sealed class car
    {
        public string display()
        {
            var data = new {
                firstName = "Praveen",
                rollno = 1234
            };

            Console.WriteLine(data);
            return ("I am in Display class Car");
        }
        public string print()
        {
            return ("I am in Print class car");
        }
    }
}
