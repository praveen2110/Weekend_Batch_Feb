using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_C__examples
{
    public class Key_Value_Pair_Example
    {
        public Hashtable Hashtableexampe()
        {
            Hashtable ht = new Hashtable();
            ht.Add("C#", "ASP.net");
            ht.Add(1, 2);
            ht.Add(2.33, "HTML,CSS,Javascript");

            return ht;
        }



        public Dictionary<int,string> dicExample()
        {
            Dictionary<int, string> di = new Dictionary<int, string>();
            di.Add(1, "C#");
            di.Add(2,"SQL Server");
            di.Add(3, "ASP.NET MVC");

            return di;
        }

        public SortedList sortedlistexample()
        {
            SortedList st = new SortedList();                        
            st.Add(10,"9");
            st.Add(3,4);
            st.Add(1,"2");

            return st;
        }

        public SortedList<string, string> genericSortedList()
        {
            SortedList<string,string> st = new SortedList<string,string>();
            st.Add("HTML", "HTML,CSS,Javascript");
            st.Add("C#", "ASP.net");

            return st;
        }
    }
}
