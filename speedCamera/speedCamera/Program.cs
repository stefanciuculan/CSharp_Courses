using System;


namespace speedCamera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Speed limit is: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Car speed is: ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed <= speedLimit)
                Console.WriteLine("OK");
            else
            {
                if (carSpeed - speedLimit <= 4)
                    Console.WriteLine("Over the speed limit but no demerit points incurred.");
                else
                {
                    var incurredPoints = (carSpeed - speedLimit) / 5;
                    Console.WriteLine("Incurred demerit points: " + incurredPoints);

                    if (incurredPoints >= 12)
                        Console.WriteLine("License suspended!");

                }
            }
        }
    }
}
