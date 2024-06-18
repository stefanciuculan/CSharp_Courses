using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercitii5
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Stefan\Desktop\NewFile";
            File.WriteAllText(path, "Ce mai este de facut acum? Cred ca nimic.");
            
            var text = File.ReadAllText(path);
            var words = text.Split(' ','.','?');

            var longestWord = words[0];
            for(var i = 1; i < words.Length; i++)
            {
                if (longestWord.Length < words[i].Length)
                    longestWord = words[i];
                else
                    if(longestWord.Length == words[i].Length)
                        Console.WriteLine(words[i]);
            }

            Console.WriteLine(longestWord);

            //if(File.Exists(path))
            //    Console.WriteLine("Exista");
            //else
            //    Console.WriteLine("Nu exista");
        }
    }
}
