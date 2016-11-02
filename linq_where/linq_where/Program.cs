using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Dictionary<int, string>();
            d.Add(1, "นายกิตติชัย โปทาวี");
            d.Add(2, "นางสาวจุฑามาศ สวัสดี");
            d.Add(3, "นางสาวชนิตรนันทน์ แสนบูรณพันธ์");
            d.Add(4, "นายฐปนนท์ ราชสังข์");

            var posi = from a in d
                       where a.Value == "นายฐปนนท์ ราชสังข์"
                       select a.Key;

            foreach (var po in posi)
            {
                Console.WriteLine(po);
            }
        }
    }
}