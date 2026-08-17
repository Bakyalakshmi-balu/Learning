namespace MyApp{ 
    public interface IPayment{
    void pay(double amount);
    
}

public abstract class Payment{
    public abstract void pay(double amount);
    public virtual void refund(double amount){
        Console.WriteLine("Refund amount of " + amount);
    }
}

public class CreditCardPayment : IPayment{
    public void pay(double amount){
        Console.WriteLine($"Paid {amount} using Credit Card.");
    }
}

public class UPIPayment : Payment{
    public override void pay(double amount){
        Console.WriteLine($"Paid {amount} using UPI.");
    }
    public override void refund(double amount){
        Console.WriteLine($"Double Refunded {amount} using UPI.");
}
}

}