using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        IPayment paymentMethod = new CreditCardPayment();
        paymentMethod.pay(100);
        //paymentMethod.refund(20);
        Console.WriteLine ("Start small. Ship something.");
    }
}

public interface IPayment{
    void pay(double amount);
    
}

public abstract class Payment{
    public abstract void pay(double amount);
    public void refund(double amount){
        Console.WriteLine("Refund amount of " + amount);
    }
}


public class CreditCardPayment : IPayment{
    public void pay(double amount){
        Console.WriteLine($"Paid {amount} using Credit Card.");
    }
}