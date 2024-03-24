using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Abstraction
{
    public class Toyota : Cars
    {
        public string DiscountPrice()
        {
            return "20% on DownPayment";
        }
        public override string colors()
        {
            return "black,blue,red,silver,white";
        }
        public override double price()
        {
            return 1450000.00;
        }
        public override int gettotalseat()
        {
            return 6;
        }
    }
}
