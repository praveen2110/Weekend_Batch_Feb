using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            car obj = new car();
           Console.WriteLine(obj.display());
            //Console.WriteLine(obj.print());
            //obj.newMethod();

            

            Console.ReadKey();
        }
    }
}
