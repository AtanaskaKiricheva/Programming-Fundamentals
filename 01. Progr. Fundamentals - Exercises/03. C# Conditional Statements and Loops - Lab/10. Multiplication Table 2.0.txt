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
            var a = int.Parse(Console.ReadLine());

            if (a>10)
            {
                Console.WriteLine($"{n} X {a} = {n*a}");
            }

            for (int i = a; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n*i}");
            }


        }
    }
}
