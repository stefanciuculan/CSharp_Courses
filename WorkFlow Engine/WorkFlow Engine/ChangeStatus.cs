using System;

namespace WorkFlow_Engine
{
    public class ChangeStatus : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Status changed.");
        }
    }
}
