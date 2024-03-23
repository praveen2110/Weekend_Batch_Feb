using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps_Inheritance
{
    public class ClassA 
    {
        public int a;
        public int b;
        

        //public int A 
        //{
        //    get;set;
        //}

        //public int B
        //{
        //    get;set;
        //}

        public ClassA()
        {
            a = 10;
            b = 20;
        }

        
        public int sum(int C)
        {
            int sum = a+b+ C ;
            //Console.WriteLine(C);
            return sum;
        }

        //public double sum(double c)
        //{
        //    double sum = A + B + c;
        //    return sum;
        //}


    }
}
