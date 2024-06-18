using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitii4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a time value in the 24-hour format   ");
            var input = Console.ReadLine();

            ValidTime(input);
        }

        public static void ValidTime(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var split = input.Split(':');

            if (split.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(split[0]);
                var minute = Convert.ToInt32(split[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }
        }

    }
}
