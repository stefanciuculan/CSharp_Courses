using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlow_Engine
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var workFlow = new WorkFlow();
            var workFlowEngine = new WorkFlowEngine();

            workFlowEngine.Run(workFlow);

            Console.WriteLine("Done.");
        }
    }
}
