using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Interface_demo
{
    public class Hyundai : Cars,INewfeatureHyundai
    {
        public string DiscountPrice()
        {
            return "40% on DownPayment";
        }

        public void GPS()
        {
            Console.WriteLine("GPS is working");
        }
    }
}
