using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitii3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            Console.WriteLine("Supply a list of comma separated numbers:");
            
            while (true)
            {
                var input = Console.ReadLine();
                for (var i = 0; i < input.Split(',').Length; i++)
                {
                    numbers.Add(Convert.ToInt32(input.Split(',')[i]));
                }

                if(numbers.Count() < 5 )
                {
                    Console.WriteLine("Invalid list. Retry please.");
                    continue;
                }
                else
                {
                    Console.Write("3 of smallest numbers in the list are: ");
                    for(var i = 1; i <= 3; i++)
                    {
                        Console.Write(numbers.Min() + " ");
                        numbers.Remove(numbers.Min());
                    }
                    break;
                }
            }
            Console.WriteLine();

        }
    }
}
