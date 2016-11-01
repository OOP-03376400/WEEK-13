using System;
using System.Linq;

namespace Operators
{
    class Cast
    {
        static void Main(string[] args)
        {
            Plant[] plants = new Plant[] {new CarnivorousPlant { Name = "Venus Fly Trap", TrapType = "Snap Trap" },
                                      new CarnivorousPlant { Name = "Pitcher Plant", TrapType = "Pitfall Trap" },
                                      new CarnivorousPlant { Name = "Sundew", TrapType = "Flypaper Trap" },
                                      new CarnivorousPlant { Name = "Waterwheel Plant", TrapType = "Snap Trap" }};

            var query = from CarnivorousPlant cPlant in plants
                        where cPlant.TrapType == "Snap Trap"
                        select cPlant;

            foreach (var e in query)
            {
                Console.WriteLine("Name = {0} , Trap Type = {1}",
                                  e.Name, e.TrapType);
            }

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
    }

    class Plant
    {
        public string Name { get; set; }
    }

    class CarnivorousPlant : Plant
    {
        public string TrapType { get; set; }
    }
}
