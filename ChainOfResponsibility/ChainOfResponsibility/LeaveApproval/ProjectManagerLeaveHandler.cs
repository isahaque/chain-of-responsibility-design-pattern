namespace ChainOfResponsibility.LeaveApproval
{
    public class ProjectManagerLeaveHandler:LeaveHandler
    {
        private readonly int maxNumberOfLeavesCanApprove = 3;
        public override void HandleRequest(string employeeName, int numberOfDays)
        {
            
            if (maxNumberOfLeavesCanApprove >= numberOfDays)
            {
                Console.WriteLine($"Leave Request for {employeeName} approved by Project Manager");
            }
            else
            {
                NextHandler.HandleRequest(employeeName, numberOfDays);
            }
        }
    }
}
