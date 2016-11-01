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
            List<string> words = new List<string>() { "an", "apple", "a", "day" };

            var query = from word in words
                        select word.Substring(0, 1);

            foreach (string s in query)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}