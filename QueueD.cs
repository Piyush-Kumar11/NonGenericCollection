using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollections
{
    internal class QueueD
    {
        public static void QueueDemo()
        {
            Queue q = new Queue();
            //In LILO / FIFO order
            q.Enqueue(2);
            q.Enqueue("Hii");
            q.Enqueue('P');
            q.Enqueue(55.88);
            q.Enqueue(false);
            q.Enqueue(null);
            q.Enqueue(null);

            foreach(object o in q)
            {
                Console.WriteLine(o);
            }
        }
    }
}
