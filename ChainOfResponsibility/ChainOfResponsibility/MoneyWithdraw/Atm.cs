namespace ChainOfResponsibility.MoneyWithdraw
{
    public class Atm
    {
        private readonly OneThousandNoteHandler oneThousandNoteHandler=new OneThousandNoteHandler();
        private readonly FiveHundredNoteHandler fiveHundredNoteHandler=new FiveHundredNoteHandler();
        private readonly OneHundredNoteHandler oneHundredNoteHandler=new OneHundredNoteHandler();
        public Atm()
        {
            oneThousandNoteHandler.SetNextHandler(fiveHundredNoteHandler);
            fiveHundredNoteHandler.SetNextHandler(oneHundredNoteHandler);
        }
        public void Withdraw(long requestedAmount)
        {
            if (requestedAmount % 100 == 0)
            {
                oneThousandNoteHandler.DispatchNotesOfAmount(requestedAmount);
            }
            else
            {
                Console.WriteLine("Amount should be multiple of 100");
            }
        }
    }
}
