using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            while (true)
            {
                Console.Write("enter a command: ");
                var input = Console.ReadLine();

                if (input == "push")
                {
                    Console.Write("Enter a object to be pushed into the stack: ");
                    object obj = Console.ReadLine();

                    stack.Push(obj);
                    Console.WriteLine("Object pushed");
                }
                else
                {
                    if(input == "pop")
                    {
                        Console.WriteLine(stack.Pop());
                    }
                    else
                    {
                        if (input == "clear")
                        {
                            stack.Clear();
                        }
                        else
                            throw new InvalidOperationException("Not a valid command");
                    }
                }
            }
        }
    }
}
