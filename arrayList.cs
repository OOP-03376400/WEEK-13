// from https://www.tutorialspoint.com/csharp/csharp_arraylist.htm

using System;
using System.Collections;

namespace CollectionApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();                 // สร้าง Object ของ ArrayList

            Console.WriteLine("Adding some numbers:");
            al.Add(45);  //เพิ่ม ข้อมูลเข้าไปยัง collection
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);

            Console.WriteLine("Capacity: {0} ", al.Capacity);   // ใช้ property Capacity
            Console.WriteLine("Count: {0}", al.Count);          // ใช้ property Count       

            Console.Write("Content: ");
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.Write("Sorted Content: ");
            al.Sort();                              // ใช้ method Sort()
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
