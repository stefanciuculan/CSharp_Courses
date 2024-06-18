namespace WorkFlow_Engine
{
    public class WorkFlow
    {
        public UploadVideo Upload { get; set; }
        public CallWebService Call { get; set; }
        public SendEMail Send { get; set; }
        public ChangeStatus Change { get; set; }
    }
}