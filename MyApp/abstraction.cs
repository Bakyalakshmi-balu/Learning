namespace MyApp{ 

    // abstract class and interface
    public interface IPayment{
    void pay(double amount);
    
}

// abstract class Payment with an abstract method pay and a virtual method refund
// abstract class with body
//abstract without body
// abstract class Payment with an abstract method pay and a virtual method refund
// virtual method with body

public abstract class Payment{
    public abstract void pay(double amount);
    public virtual void refund(double amount){
        Console.WriteLine("Refund amount of " + amount);
    }
}

// class CreditCardPayment that implements the IPayment interface and provides its own implementation of the pay method
public class CreditCardPayment : IPayment{
    public void pay(double amount){
        Console.WriteLine($"Paid {amount} using Credit Card.");
    }
}

// class UPIPayment that inherits from the abstract class Payment and provides its own implementation of the pay method and overrides the refund method
public class UPIPayment : Payment{

    // override the pay method from the abstract class Payment
    public override void pay(double amount){
        Console.WriteLine($"Paid {amount} using UPI.");
    }

    // override the refund method from the abstract class Payment
    public override void refund(double amount){
        Console.WriteLine($"Double Refunded {amount} using UPI.");
}
}

}