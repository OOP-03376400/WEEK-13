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
            List<string> words = new List<string>() { "an", "apple", "pine", "day" };

            var query = from word in words   // word = string, words = list of string
                        select word.Substring(0, 2); // select first char of word

            foreach (string s in query)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}