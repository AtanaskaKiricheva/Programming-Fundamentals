using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var z = int.Parse(Console.ReadLine());

            Console.WriteLine($"{n} + {z} = {n+z}");
        }
    }
}
