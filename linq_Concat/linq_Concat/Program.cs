using System;
using System.Collections.Generic;
using System.Linq;

namespace Operators
{
    class Concat
    {
        static void Main(string[] args)
        {
            Pet[] cats = GetCats();
            Pet[] dogs = GetDogs();

            IEnumerable<string> query = cats.Select(cat => cat.Name).Concat(dogs.Select(dog => dog.Name));

            foreach (var e in query)
            {
                Console.WriteLine("Name = {0} ", e);
            }

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }

        static Pet[] GetCats()
        {
            Pet[] cats = { new Pet { Name="Barley", Age=8 },
                       new Pet { Name="Boots", Age=4 },
                       new Pet { Name="Whiskers", Age=1 } };
            return cats;
        }

        static Pet[] GetDogs()
        {
            Pet[] dogs = { new Pet { Name="Bounder", Age=3 },
                       new Pet { Name="Snoopy", Age=14 },
                       new Pet { Name="Fido", Age=9 } };
            return dogs;
        }
    }

    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}