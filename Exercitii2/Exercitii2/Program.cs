using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitii2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = new Random().Next(1, 10);
            for(var i = 1; i <=4; i++)
            {
                Console.WriteLine("Your guess is: ");
                var input = Convert.ToInt32(Console.ReadLine());
                
                if(input == number)
                {
                    Console.WriteLine("You won!");
                    return;
                }
            }
            Console.WriteLine("This was your last try. You lost!");
        }
    }
}
