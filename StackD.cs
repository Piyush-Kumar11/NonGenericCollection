using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollections
{
    internal class StackD
    {
        public static void StackDemo()
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push("Hello");
            s.Push('K');
            s.Push(5.6);
            s.Push(null);
            s.Push(null);
//In LIFO / FILO order

            //foreach (var x in s)
            //{
            //    Console.WriteLine(x);
            //}
            foreach (object x in s)
            {
                Console.WriteLine(x);
            }
        }
    }
}
