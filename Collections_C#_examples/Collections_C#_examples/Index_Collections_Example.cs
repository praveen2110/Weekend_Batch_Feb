using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_C__examples
{
    public class Index_Collections_Example
    {
        public ArrayList arraylistexample() 
        {
            ArrayList al = new ArrayList();
           
            string str = "Teja";
            int x = 7;
            DateTime date = DateTime.Parse("8-Oct-1999");

            al.Add(str);
            al.Add(x);
            al.Add(date);
            
            return al;
        }

        public List<string> listexample()
        {
            List<string> li = new List<string>();

            string str = "Teja";            
            string str2 = "Kumar";
            string date = DateTime.Parse("8-Oct-1999").ToString();

            li.Add(str);
            li.Add(str2);
            li.Add(date);
                       

            return li;
        }



    }
}
