using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_Operators_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Enter the value of a");
            a = Convert.ToInt32(Console.ReadLine()); //2

            //int result = a++; // result = a+1 //Uniary Post Increamantal

            //int result = a--; // result = a -1 // uniary Post decremental 

            //int result = ++a; // result = a +1 //Uniary Pre Incremental 
            int result = --a; // result = a -1 // uniary Pre decremental 

            Console.WriteLine(result);
            Console.WriteLine(a);

            bool noolresult = (a == 8) ? (a > 2 ) ? true : false : false;

            

            



                //Console.WriteLine(result);


                Console.ReadKey();

            //Operators

            //Write a program to check if the number is prime or not 
            // 

            //Break and continue 

            // Loops 
        }

       
    }
}
