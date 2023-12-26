namespace ChainOfResponsibility.LeaveApproval
{
    public class HRLeaveHandler:LeaveHandler
    {
        private readonly int maxNumberOfLeavesCanApprove = 5;
        public override void HandleRequest(string employeeName, int numberOfDays)
        {
            
            if (maxNumberOfLeavesCanApprove >= numberOfDays)
            {
                Console.WriteLine($"Leave Request for {employeeName} approved by HR");
            }
            else
            {
                Console.WriteLine($"Leave Request for {employeeName} rejected by HR");
            }
        }
    }
}
