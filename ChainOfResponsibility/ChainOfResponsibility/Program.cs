// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility.LeaveApproval;
using ChainOfResponsibility.MoneyWithdraw;

Console.WriteLine("Hello, World!");

//var atm = new Atm();
//atm.Withdraw(400);

var leaveApprover = new LeaveApprover();
leaveApprover.ApproveLeave("John", 2);

Console.ReadLine();