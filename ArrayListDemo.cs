using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollections
{
    internal class ListDemo
    {
        public static void ArrayListDemo()
        {
            ArrayList al = new ArrayList();
            al.Add(23);
            al.Add("Hello");
            al.Add(5.88);
            al.Add('P');
            al.Add(true);

            foreach(var v in al)
            {
                Console.Write(v+" ");
            }
        }
    }
}
