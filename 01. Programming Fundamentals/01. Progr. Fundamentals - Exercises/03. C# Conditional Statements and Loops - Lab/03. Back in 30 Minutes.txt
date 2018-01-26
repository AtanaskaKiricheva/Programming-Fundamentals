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
            var h = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());

            var after = m + 30;

            if (after>59)
            {
                h++;
                after -= 60;
            }
            if (h>23)
            {
                h = 0;
            }
            Console.WriteLine("{0}:{1:d2}",h,after);
        }
    }
}
