using System;

namespace WorkFlow_Engine
{
    public class SendEMail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("E-mail sent.");
        }
    }
}
