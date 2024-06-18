using System;

namespace WorkFlow_Engine
{
    public class CallWebService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Web service called.");
        }
    }
}
