﻿namespace ChainOfResponsibility.MoneyWithdraw
{
    public class FiveHundredNoteHandler:NotesHandler
    {
        public override void DispatchNotesOfAmount(long requestedAmount)
        {
            const int noteDenomination = 500;
            long numberOfNotesTobeDispatched = requestedAmount / noteDenomination;
            if (numberOfNotesTobeDispatched>0)
            {
                long pendingAmount = requestedAmount % noteDenomination;
                Console.WriteLine($"Dispatching {numberOfNotesTobeDispatched} notes of {noteDenomination}");
                if (pendingAmount>0)
                {
                    NextHandler.DispatchNotesOfAmount(pendingAmount);
                }
            }
            else
            {
                NextHandler.DispatchNotesOfAmount(requestedAmount);
            }
        }
    }
}
