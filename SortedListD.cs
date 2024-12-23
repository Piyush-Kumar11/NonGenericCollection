using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollections
{
    internal class SortedListD
    {
        public static void SortedListDemo()
        {
            SortedList s = new SortedList();
            s.Add(1, "Hii");
            s.Add(5, 33);
            s.Add(3, "C#");
            //s.Add(null, "Java"); Key cannot be null.

            foreach (DictionaryEntry i in s)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
        }
    }
}
