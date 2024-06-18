using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitii4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a few numbers separated by hyphen: ");
            var input = Console.ReadLine();

            var numbers = new List<int>();
            CharToNumbers(input, numbers);

            if (IsConsecutive(numbers))
                Console.WriteLine("Consecutive");
            else
                Console.WriteLine("Not consecutive");
        }

        public static void CharToNumbers(string strNumbers, List<int> numbers)
        {
            foreach (var number in strNumbers.Split('-'))
                numbers.Add(Convert.ToInt32(number));
        }

        public static bool IsConsecutive(List<int> numbers)
        {
            var isConsecutive = true;
            for(var i = 1; i < numbers.Count; i++)
                if(numbers[i - 1] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            return isConsecutive;
        }

    }
}
