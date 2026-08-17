using System;
using MyApp;
namespace MyApp{ 
    class Program
{
    public static void Main(string[] args)
    {
        Payment paymentMethod = new UPIPayment();
        paymentMethod.pay(100);
        paymentMethod.refund(20);
        Console.WriteLine ("Start small. Ship something.");
        ///encapsultion
        BankAccount account = new BankAccount();
        account.deposite(1000);
        account.withdrawal(500);
        double balance = account.getbalance();
        Console.WriteLine("My Balance is " + balance);
        // account.balance=account.balance-500;
        // Console.WriteLine("My Balance is " + account.balance);

    }
}

}
