using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Abstraction
{
    public class Hyundai : Cars
    {
        public string DiscountPrice()
        {
            return "40% on DownPayment";
        }
        public override string colors()
        {
            return "silver,white";
        }
        public override double price()
        {
            return 800000.00;
        }
        public override int gettotalseat()
        {
            return 4;
        }
    }
}
