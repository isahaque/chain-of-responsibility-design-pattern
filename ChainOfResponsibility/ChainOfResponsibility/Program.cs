// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility.MoneyWithdraw;

Console.WriteLine("Hello, World!");

var atm = new Atm();
atm.Withdraw(400);

Console.ReadLine();