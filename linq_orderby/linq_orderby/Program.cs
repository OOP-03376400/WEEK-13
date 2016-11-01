using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { -20, 12, 6, 10, 0, -3, 1 };
            //create a query that obtain the values in sorted order
            var posNums = from n in num
                          orderby n
                          select n;
            Console.Write("Values in ascending order: ");

            // Execute the query and display the results.
            foreach (int i in posNums)
                Console.Write(i + " \n");

            var posNumsDesc = from n in num
                              orderby n descending
                              select n;
            Console.Write("\nValues in descending order: ");

            // Execute the query and display the results.
            foreach (int i in posNumsDesc)
                Console.Write(i + " \n");

            Console.ReadLine();
        }
    }
}