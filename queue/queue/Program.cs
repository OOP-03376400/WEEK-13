using System;
using System.Collections;

namespace CollectionsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue("Ovaltine");
            q.Enqueue("Milo");
            q.Enqueue("Coco");
            q.Enqueue("Wine");

            Console.WriteLine("Current queue: ");
            foreach (string g in q) Console.Write(g + " ");

            Console.WriteLine();
            q.Enqueue("Vita berry");
            q.Enqueue("Hong tong");
            Console.WriteLine("Current queue: ");
            foreach (string g in q) Console.Write(g + " ");

            Console.WriteLine();
            Console.WriteLine("Removing some values ");
            string str = (string)q.Dequeue();
            Console.WriteLine("The removed value: {0}", str);
            str= (string)q.Dequeue();
            Console.WriteLine("The removed value: {0}", str);
            str = (string)q.Dequeue();
            Console.WriteLine("The removed value: {0}", str);
            str = (string)q.Dequeue();
            Console.WriteLine("The removed value: {0}", str);
            str = (string)q.Dequeue();
            Console.WriteLine("The removed value: {0}", str);
 
            Console.ReadKey();
        }
    }
}
