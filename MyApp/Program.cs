using System;
using MyApp;
namespace MyApp{ 
    class Program
{
    public static void Main(string[] args)
    {
        // Payment paymentMethod = new UPIPayment();
        // paymentMethod.pay(100);
        // paymentMethod.refund(20);
        // Console.WriteLine ("Start small. Ship something.");
        // ///encapsultion
        // BankAccount account = new BankAccount();
        // account.deposite(1000);
        // account.withdrawal(500);
        // double balance = account.getbalance();
        // Console.WriteLine("My Balance is " + balance);
        // account.balance=account.balance-500;
        // Shape shape = new Shape();
        // double squareArea = shape.Area(5);

        // double rectangleArea = shape.Area(5,10);

        // Console.WriteLine("My Square Area " + squareArea);
        // Console.WriteLine("My Rectangle Area " + rectangleArea);


        // NotificationService service = new NotificationService();
        // service.send(new EmailNotification());
        // service.send(new SMSNotification());
        // service.send(new InstagramNotification());
        
// created object of Manager class and called the login and manageMeeting methods
         Manager manager = new Manager(101, "Deepak", 
        "deepak@example.com", "IT", 1234567890);

        manager.login();
        manager.manageMeeting();


// created object of Developer class and called the login and writeCode methods
        Developer developer = new Developer(102, "Bakya", "Bakya@gmail.com", "R&D", 980789674);
        developer.login();

        developer.writeCode();
    }
}

}
