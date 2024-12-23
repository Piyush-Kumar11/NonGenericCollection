using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollections
{
    internal class HashTableD
    {
        public static void HashTableDemo()
        {
            Hashtable h = new Hashtable();
            //Doesn't maintains insertion order
            h.Add("Name:", "Piyush");
            h.Add("Roll:", 21);
            //h.Add(null, 'H'); Key cannot be null
            h.Add(1, "Java");
            h.Add("LastName:", "Kumar");

            foreach(DictionaryEntry d in h)
            {
                Console.WriteLine(d.Key+" "+d.Value);
            }
        }
    }
}
