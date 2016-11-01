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
            string[] words = { "humpty", "dumpty", "set", "on", "a", "wall" };

            IEnumerable<string> query = from word in words
                                        where word.Length == 3
                                        select word;
            foreach (string str in query)
                Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}