namespace ChainOfResponsibility.LeaveApproval
{
    public abstract class LeaveHandler
    {
        public LeaveHandler NextHandler;
        public void SetNextHandler(LeaveHandler handler)
        {
            NextHandler = handler;
        }

        public abstract void HandleRequest(string employeeName,int numberOfDays);
    }
}
