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

            var odd = 0;
            var sum = 0;
            Console.WriteLine(1);
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(i+2+odd);
                sum += i + 2 + odd;
                odd++;
            }
            Console.WriteLine("Sum: {0}", sum+1);


        }
    }
}
