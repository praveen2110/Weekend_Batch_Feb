using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Interface_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Toyota ty = new Toyota();
            Console.WriteLine(ty.DiscountPrice());
            Console.WriteLine(ty.CheckAC());
            Console.WriteLine(ty.Music());
            Console.WriteLine(ty.wheel());

            Console.WriteLine("================================================================");

            Hyundai Hy = new Hyundai();
            Console.WriteLine(Hy.DiscountPrice());
            Console.WriteLine(Hy.CheckAC());
            Console.WriteLine(Hy.Music());
            Console.WriteLine(Hy.wheel());
            
            //GPS: is only present in Hyundai but not in TOyato


            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
