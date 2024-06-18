using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitii4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a few words ");
            var input = Console.ReadLine();

            var builder = new StringBuilder();

            builder.AppendFormat("PascalCase", input);
            Console.WriteLine(builder);
        }
    }
}
