using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Strings_2D_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays and Strings 
            //< datatype >[] < variable name > = new int[size of array];
            int[] a = new int[10];
            for (int j = 0; j < 10; j++)
            {
                for (int i = 1; i <= 20; i++)
                {
                    if (i % 2 == 0)
                    {
                        a[j] = i;
                        j++;
                    }
                }
            }

            Console.WriteLine("Enter the rows and column of Matericse:");
            int rows = Convert.ToInt32(Console.ReadLine());
            int column = Convert.ToInt32(Console.ReadLine());

            int[,] A = new int[rows,column];

            int n = 1;
            

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column;j++)
                {
                    while (j < column)
                    {
                        if (n % 2 == 0)
                        {
                            A[i, j] = n;
                            j++;
                        }
                        n++;
                    }                    
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column;j++)
                {
                    Console.Write($"{ A[i, j] }");
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }





            Console.ReadKey();
        }
    }
}
