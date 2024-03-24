using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Abstraction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Toyota ty = new Toyota();
            Console.WriteLine(ty.DiscountPrice());
            Console.WriteLine(ty.CheckAC());
            Console.WriteLine(ty.Music());
            Console.WriteLine(ty.wheel());
            Console.WriteLine(ty.gettotalseat());
            Console.WriteLine(ty.colors());
            Console.WriteLine(ty.price());

            Hyundai Hy = new Hyundai();
            Console.WriteLine(Hy.DiscountPrice());
            Console.WriteLine(Hy.CheckAC());
            Console.WriteLine(Hy.Music());
            Console.WriteLine(Hy.wheel());
            Console.WriteLine(Hy.gettotalseat());
            Console.WriteLine(Hy.colors());
            Console.WriteLine(Hy.price());


            Console.ReadKey();
        }
    }
}
