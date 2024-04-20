using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptional_Handling
{
    public class Program
    {
        public static void Main(string[] args)
        {

            try
            {
                int a = 20;
                int b = 0;
                int c;
                //int[] ar = new int[10];
                //Console.WriteLine(ar[11]);
                //c = a / b;

                Console.WriteLine("Inside Try");
                //Console.WriteLine(c);

            }
            catch (DivideByZeroException e)
            {
                throw;

            }
            catch (Exception e)
            {
                throw e;
            }
            finally 
            {
                Console.WriteLine("Inside Finally"); //SQL , File , API 
            }

            Console.ReadKey();

        }
    }
}
