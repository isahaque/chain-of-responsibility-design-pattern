namespace ChainOfResponsibility.LeaveApproval
{
    public class LeaveApprover
    {
        private readonly TeamLeadLeaveHandler _teamLeadLeaveHandler=new TeamLeadLeaveHandler();
        private readonly ProjectManagerLeaveHandler _projectManagerLeaveHandler=new ProjectManagerLeaveHandler();
        private readonly HRLeaveHandler _hrLeaveHandler=new HRLeaveHandler();
        public LeaveApprover()
        {
            _teamLeadLeaveHandler.SetNextHandler(_projectManagerLeaveHandler);
            _projectManagerLeaveHandler.SetNextHandler(_hrLeaveHandler);
        }

        public void ApproveLeave(string employeeName,int numberOfDays)
        {
            _teamLeadLeaveHandler.HandleRequest(employeeName, numberOfDays);
        }

    }
}
