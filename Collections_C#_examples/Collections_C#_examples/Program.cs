using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_C__examples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Index_Collections_Example icex = new Index_Collections_Example();
            Console.WriteLine("Index Base Collection example:");
            Console.WriteLine("***************************************************************************************");
            ArrayList ar = new ArrayList();
            ar = icex.arraylistexample(); 
            Console.WriteLine("ArrayList example:");
            foreach(object o in ar)
                Console.WriteLine(o);
            Console.WriteLine("######################################################");
            List<string> li = new List<string>();
            li = icex.listexample();
            Console.WriteLine("List example:");            
            foreach (string o in li)
                Console.WriteLine(o);
            Console.WriteLine("######################################################");

            Key_Value_Pair_Example kvpe = new Key_Value_Pair_Example();
            Console.WriteLine("Key Value Pair Collection example:");
            Console.WriteLine("***************************************************************************************");
            Hashtable ht = new Hashtable();
            ht = kvpe.Hashtableexampe();
            Console.WriteLine("HashTable example:");
            foreach (DictionaryEntry o in ht)
                Console.WriteLine(o.Key + " " + o.Value);
            Console.WriteLine("######################################################");
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic = kvpe.dicExample();
            Console.WriteLine("Dictionary Example");
            foreach (KeyValuePair<int, string> kvpair in dic)
                Console.WriteLine(kvpair.Key + " " + kvpair.Value);
            Console.WriteLine("######################################################");
            SortedList st = new SortedList();
            st = kvpe.sortedlistexample();
            Console.WriteLine("SortedList example Non Generic");
            foreach (DictionaryEntry o in st)
                Console.WriteLine(o.Key + " " + o.Value);
            Console.WriteLine("######################################################");
            SortedList<string,string> stg = new SortedList<string,string>();
            stg = kvpe.genericSortedList();
            Console.WriteLine("SortedList example Generic");
            foreach (KeyValuePair<string,string> o in stg)
                Console.WriteLine(o.Key + " " + o.Value);
            Console.WriteLine("######################################################");





            Console.ReadKey();
        }
    }
}
