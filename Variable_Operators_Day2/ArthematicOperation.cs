using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_Operators_Day2
{
    public class ArthematicOperation
    {
        public double mydivision(double num1, double num2 = 2)
        {
            double division = num1 / num2;

            return division;
        }
        public double myModulues(double a, double b)
        {
            double mod = a % b;

            return mod;
        }

        public bool isPrime(int n,int divisor = 2)
        {

            if (n == 2)
            {
                return true;
            }
            else if (n % divisor != 0 && (divisor * divisor > n || isPrime(n, divisor + 1)))
            {
                return true;
            }
            else
            {
                return false;
            }

            //Recursion 

            //return n == 2 || (n % divisor != 0 && (divisor * divisor > n || isPrime(n, divisor + 1)));
            
        }
        

    }
}
