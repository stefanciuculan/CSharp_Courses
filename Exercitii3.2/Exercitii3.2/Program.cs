using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitii3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type your name ");
            string name = Console.ReadLine();
            var nameArray = new char[name.Length];

            string reversedName;

            for (int i = name.Length; i > 0; i--)
                nameArray[name.Length - i] = name[i - 1];

            reversedName = new string(nameArray);
            Console.WriteLine(reversedName);
        }
    }
}
