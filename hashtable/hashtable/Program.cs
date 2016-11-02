using System;
using System.Collections;

namespace CollectionsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("001", "Thitima");
            ht.Add("002", "Chanitnantranukool");
            ht.Add("003", "Snakepong");
            ht.Add("004", "Phairote");
            ht.Add("005", "Thanakorn");
            ht.Add("006", "Anukorn");
            ht.Add("007", "Vipapan");

            if (ht.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                ht.Add("008", "Nuha Ali");
            }

            // Get a collection of the keys.
            ICollection key = ht.Keys;

            //if (ht.ContainsKey("015"))
            //{
                Console.WriteLine(ht["015"]);
            //}
            //foreach (string k in key)
            //{
            //    Console.WriteLine(k + ": " + ht[k]);
            //}

            Console.ReadKey();
        }
    }
}
