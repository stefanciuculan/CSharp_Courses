
namespace WorkFlow_Engine
{
    public class WorkFlowEngine
    {
        public void Run(WorkFlow workFlow)
        {
            //workFlow.Upload.Execute();
            //workFlow.Call.Execute();
            //workFlow.Send.Execute();
            workFlow.Change.Execute();
        }
    }
}
