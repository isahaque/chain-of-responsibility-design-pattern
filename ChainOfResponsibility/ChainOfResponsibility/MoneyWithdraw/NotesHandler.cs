namespace ChainOfResponsibility.MoneyWithdraw
{
    public abstract class NotesHandler
    {
        public NotesHandler NextHandler;
        public void SetNextHandler(NotesHandler handler)
        {
            NextHandler = handler;
        }
        public abstract void DispatchNotesOfAmount(long requestedAmount);
    }
}
