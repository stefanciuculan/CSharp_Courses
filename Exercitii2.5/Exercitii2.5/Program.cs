﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitii2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type five numbers separated by comma: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            var max = Convert.ToInt32(numbers[0]) ;
            foreach(var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }
            Console.WriteLine("Max number is " + max);
        }
    }
}
