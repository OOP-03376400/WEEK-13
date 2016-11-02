// from https://www.tutorialspoint.com/csharp/csharp_arraylist.htm

using System;
using System.Collections;

namespace CollectionApplication
{
    class Program ////
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();                 // สร้าง Object ของ ArrayList
            const int length = 1025;
            Console.WriteLine("Adding some numbers:");
            for (int i = 0; i < length; i++)
            {
                al.Add(i);

            }

            Console.WriteLine("Capacity: {0} ", al.Capacity);   // ใช้ property Capacity
            Console.WriteLine("Count: {0}", al.Count);          // ใช้ property Count 
            Console.WriteLine("waste: {0}", al.Capacity - al.Count);          // ใช้ property Count 
                  
            Console.ReadKey();

            al.TrimToSize();
            Console.WriteLine("After trim to size");   // ใช้ property Capacity
            Console.WriteLine("Capacity: {0} ", al.Capacity);   // ใช้ property Capacity
            Console.WriteLine("Count: {0}", al.Count);          // ใช้ property Count       
            Console.WriteLine("waste: {0}", al.Capacity - al.Count);          // ใช้ property Count 
            Console.ReadKey();


            Console.Write("Content: ");
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.Write("Inserted Content: ");
            al.Insert(0, 2);

            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.Write("remove: ");
            al.Remove(20);

            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            Console.ReadKey();




        }
    }
}