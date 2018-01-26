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
            var day = (Console.ReadLine());
            var age = int.Parse(Console.ReadLine());

            var price = 0;
            if (age <0 || age > 122)
            {
                Console.WriteLine("Error!");
                return;
            }
            else if (age>=0 && age <=18)
            {
                switch (day)
                {
                    case "Weekday":price = 12;       break;
                    case "Weekend": price = 15; break;
                    case "Holiday": price = 5; break;
                }
            }
            else if (age > 18 && age <= 64)
            {
                switch (day)
                {
                    case "Weekday": price = 18; break;
                    case "Weekend": price = 20; break;
                    case "Holiday": price = 12; break;
                }
            }
            else
            {
                switch (day)
                {
                    case "Weekday": price = 12; break;
                    case "Weekend": price = 15; break;
                    case "Holiday": price = 10; break;
                }
            }
            Console.WriteLine($"{price}$");
        }
    }
}
