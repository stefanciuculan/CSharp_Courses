using System;

namespace WorkFlow_Engine
{
    public class UploadVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video uploaded!");
        }
    }
}
