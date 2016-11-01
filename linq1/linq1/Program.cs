using System;
using System.Data.SqlClient;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] words = { "hello", "wonderful", "LINQ", "beautiful", "world" };
        //Get only short words
        var shortWords = from word in words
                         where word.Length <= 5
                         select word;

        //Print each word out
        foreach (var word in shortWords)
        {
            Console.WriteLine(word);
        }
        Console.ReadLine();
    }
}





