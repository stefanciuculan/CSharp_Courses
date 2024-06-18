﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            //Length
            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            //Clear()
            Array.Clear(numbers, 0, 2);

            foreach (var number in numbers)
                Console.WriteLine(number);

            //Copy()
            var another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("Effect of copy()");
            foreach (var number in another)
                Console.WriteLine(number);

            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of sort()");
            foreach (var number in numbers)
                Console.WriteLine(number);

            //Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}
