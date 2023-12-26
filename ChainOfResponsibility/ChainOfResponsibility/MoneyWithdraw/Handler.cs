namespace ChainOfResponsibility.MoneyWithdraw
{
    public abstract class Handler
    {
        public Handler NextHandler;
        public void SetNextHandler(Handler handler)
        {
            NextHandler = handler;
        }
        public abstract void DispatchNotesOfAmount(long requestedAmount);
    }
}
