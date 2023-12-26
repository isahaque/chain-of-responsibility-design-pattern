namespace ChainOfResponsibility.LeaveApproval
{
    public class TeamLeadLeaveHandler: LeaveHandler
    {
        private readonly int maxNumberOfLeavesCanApprove = 1;
        public override void HandleRequest(string employeeName, int numberOfDays)
        {
            
            if (numberOfDays <= maxNumberOfLeavesCanApprove)
            {
                Console.WriteLine($"Leave Request for {employeeName} approved by Team Lead");
            }
            else
            {
                NextHandler.HandleRequest(employeeName, numberOfDays);
            }
        }
    }
}
