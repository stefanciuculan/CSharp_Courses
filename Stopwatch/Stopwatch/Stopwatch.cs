using System;

namespace Stopwatch
{
    partial class Program
    {
        public class Stopwatch
        {
            public TimeSpan Start()
            {
                return DateTime.Now.TimeOfDay;
            }

            public TimeSpan Stop()
            {
                return DateTime.Now.TimeOfDay;
            }

            public TimeSpan Duration(TimeSpan timeStart, TimeSpan timeStop)
            {
                return timeStop.Subtract(timeStart);
            }
        }
    }
}
