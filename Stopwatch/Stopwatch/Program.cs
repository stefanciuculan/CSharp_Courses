using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    partial class Program
    {
//        Design a class called Stopwatch.The job of this class is to simulate a stopwatch.It should
//provide two methods: Start and Stop.We call the start method first, and the stop method next.
//Then we ask the stopwatch about the duration between start and stop. Duration should be a
//value in TimeSpan.Display the duration on the console.
//We should also be able to use a stopwatch multiple times.So we may start and stop it and then
//start and stop it again. Make sure the duration value each time is calculated properly.
//We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
//start time). So the class should throw an InvalidOperationException if its started twice.
        static void Main(string[] args)
        {
            var watch = new Stopwatch();

            Process(watch);
        }

        public static void Process(Stopwatch watch)
        {
            var timeStart = new TimeSpan();
            var timeStop = new TimeSpan();

            Console.WriteLine("Start your stopwatch whenever you want by typing start");
            var input = Console.ReadLine();

            if (input != "start")
                throw new InvalidOperationException("You should start the stopwatch first.");

            timeStart = watch.Start();
            Console.WriteLine("Counting . . .");

            while (true)
            {
                input = Console.ReadLine();

                if (input != "stop" && input != "close")
                    throw new InvalidOperationException("You should stop the stopwatch " +
                        "first or close the process.");
                else
                {
                    if (input == "close")
                    {
                        Console.WriteLine("Process closed");
                        return;
                    }
                    else
                    {
                        timeStop = watch.Stop();
                        Console.WriteLine(watch.Duration(timeStart, timeStop).ToString(@"mm\:ss"));
                    }
                }

                input = Console.ReadLine();

                if (input != "start" && input != "close")
                    throw new InvalidOperationException("You should restart the stopwatch " +
                        "first or close the process.");
                if (input == "close")
                {
                    Console.WriteLine("Process closed");
                    return;
                }
                Console.WriteLine("Counting . . .");
                timeStart = watch.Start();
            }
        }

    }
}
